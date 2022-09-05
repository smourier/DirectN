using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;

namespace DirectN
{
    public sealed class VerticalBlankTicker : IDisposable
    {
        private volatile bool _stop;
        private volatile bool _throw = true;
        private Thread _thread;
        private long _ticks;
        private int _tickDivider = 1;

        public event EventHandler<VerticalBlankTickerEventArgs> Tick;
        public event EventHandler<VerticalBlankTickerErrorEventArgs> WaitError;

        public string DeviceName { get; private set; }
        public bool IsRunning { get; private set; }
        public bool ThrowExceptions { get => _throw; set => _throw = value; }
        public int TickDivider { get => _tickDivider; set => _tickDivider = value.Clamp(1); }

        public void EnsureStarted(string deviceName = null, Action<Thread> configure = null)
        {
            if (!IsRunning || (deviceName != null && !deviceName.EqualsIgnoreCase(DeviceName)))
            {
                Start(deviceName, configure);
            }
        }

        public void Dispose() => Stop();

        public bool? Stop(int? waitTimeout = null)
        {
            IsRunning = false;
            var oldThread = Interlocked.Exchange(ref _thread, null);
            if (oldThread != null && oldThread.IsAlive)
            {
                _stop = true;
                if (waitTimeout.HasValue)
                    return oldThread.Join(waitTimeout.Value);

                return null;
            }
            return true;
        }

        public void Start(string deviceName = null, Action<Thread> configure = null)
        {
            Stop();
            IsRunning = true;
            _thread = new Thread(Wait);
            _thread.IsBackground = true;
            _thread.Name = "_vbt_";
            configure?.Invoke(_thread);
            _thread.Start(deviceName);
        }

        public void ResetTicks() => _ticks = 0;

        private void Wait(object state)
        {
            var deviceName = ((string)state).Nullify() ?? DISPLAY_DEVICE.Primary.DeviceName.Nullify();
            DeviceName = deviceName ?? @"\\.\DISPLAY1";

            var hdc = CreateDCW(null, DeviceName, null, IntPtr.Zero);
            if (hdc == IntPtr.Zero)
            {
                IsRunning = false;
                throw new ExternalException();
            }

            var oa = new D3DKMT_OPENADAPTERFROMHDC();
            oa.hDc = hdc;

            var status = D3DKMTOpenAdapterFromHdc(ref oa);
            DeleteDC(hdc);
            if (status < 0)
            {
                IsRunning = false;
                throw new Win32Exception(status);
            }

            var we = new D3DKMT_WAITFORVERTICALBLANKEVENT();
            we.hAdapter = oa.hAdapter;
            we.VidPnSourceId = oa.VidPnSourceId;

            var smallCount = 0;
            do
            {
                status = D3DKMTWaitForVerticalBlankEvent(ref we);
                if (status == 0)
                {
                    if (_tickDivider > 1)
                    {
                        smallCount++;
                        if (smallCount != _tickDivider)
                            continue;

                        smallCount = 0;
                    }

                    if (_throw)
                    {
                        Tick?.Invoke(null, new VerticalBlankTickerEventArgs(_ticks++));
                    }
                    else
                    {
                        try
                        {
                            Tick?.Invoke(null, new VerticalBlankTickerEventArgs(_ticks++));
                        }
                        catch
                        {
                            // continue
                        }
                    }
                }
                else
                {
                    var e = new VerticalBlankTickerErrorEventArgs(_ticks, status);
                    WaitError?.Invoke(null, e);
                    if (!e.Handled)
                    {
                        IsRunning = false;
                        throw new Win32Exception(status);
                    }
                    else
                    {
                        if (e.Stop)
                            break;
                    }
                }

                if (_stop)
                    break;
            }
            while (true);
            IsRunning = false;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct D3DKMT_OPENADAPTERFROMHDC
        {
            public IntPtr hDc;
            public int hAdapter;
            public long AdapterLuid;
            public int VidPnSourceId;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct D3DKMT_WAITFORVERTICALBLANKEVENT
        {
            public int hAdapter;
            public int hDevice;
            public int VidPnSourceId;
        }

        [DllImport("gdi32")]
        private static extern int D3DKMTWaitForVerticalBlankEvent(ref D3DKMT_WAITFORVERTICALBLANKEVENT Arg1);

        [DllImport("gdi32")]
        private static extern int D3DKMTOpenAdapterFromHdc(ref D3DKMT_OPENADAPTERFROMHDC Arg1);

        [DllImport("gdi32", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr CreateDCW(string pwszDriver, string pwszDevice, string pszPort, IntPtr pdm);

        [DllImport("gdi32")]
        private static extern bool DeleteDC(IntPtr hdc);
    }
}
