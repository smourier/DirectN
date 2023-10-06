using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct DISPLAY_DEVICE
    {
        public int cb;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceString;
        public DISPLAY_DEVICE_FLAGS StateFlags;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceID;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceKey;

        public bool IsPrimary => StateFlags.HasFlag(DISPLAY_DEVICE_FLAGS.DISPLAY_DEVICE_PRIMARY_DEVICE);

        public string MonitorName
        {
            get
            {
                var dd = new DISPLAY_DEVICE
                {
                    cb = Marshal.SizeOf<DISPLAY_DEVICE>()
                };
                _ = EnumDisplayDevices(DeviceName, 0, ref dd, 0);
                return dd.DeviceString;
            }
        }

        public override string ToString() => "Name=" + MonitorName + " (" + DeviceName + ") on " + DeviceString + ", Id=" + DeviceID + ", Key=" + DeviceKey + ", Flags=" + StateFlags;

        public Monitor Monitor
        {
            get
            {
                foreach (var monitor in Monitor.All)
                {
                    if (monitor.DeviceName.EqualsIgnoreCase(DeviceName))
                        return monitor;
                }
                return null;
            }
        }

        public static DISPLAY_DEVICE Primary => All.FirstOrDefault(d => d.StateFlags.HasFlag(DISPLAY_DEVICE_FLAGS.DISPLAY_DEVICE_PRIMARY_DEVICE));
        public static IEnumerable<DISPLAY_DEVICE> Active => All.Where(d => d.StateFlags.HasFlag(DISPLAY_DEVICE_FLAGS.DISPLAY_DEVICE_ACTIVE));
        public static IEnumerable<DISPLAY_DEVICE> All
        {
            get
            {
                var dd = new DISPLAY_DEVICE
                {
                    cb = Marshal.SizeOf<DISPLAY_DEVICE>()
                };

                var index = 0;
                do
                {
                    if (!EnumDisplayDevices(null, index++, ref dd, 0))
                        break;

                    yield return dd;
                }
                while (true);
            }
        }

        public DEVMODE CurrentSettings
        {
            get
            {
                const int ENUM_CURRENT_SETTINGS = unchecked((int)0xFFFFFFFF);
                var mode = new DEVMODE();
                _ = EnumDisplaySettings(DeviceName, ENUM_CURRENT_SETTINGS, ref mode, 0);
                return mode;
            }
        }

        public DEVMODE RegistrySettings
        {
            get
            {
                const int ENUM_REGISTRY_SETTINGS = unchecked((int)0xFFFFFFFE);
                var mode = new DEVMODE();
                _ = EnumDisplaySettings(DeviceName, ENUM_REGISTRY_SETTINGS, ref mode, 0);
                return mode;
            }
        }

        public IEnumerable<DEVMODE> GetModes(EDS flags = 0)
        {
            var i = 0;
            var mode = new DEVMODE();
            while (EnumDisplaySettings(DeviceName, i++, ref mode, flags))
            {
                yield return mode;
            }
        }

        [DllImport("user32", CharSet = CharSet.Unicode)]
        private static extern bool EnumDisplayDevices(string lpDevice, int iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, int dwFlags);

        [DllImport("user32", CharSet = CharSet.Unicode)]
        private static extern bool EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode, EDS dwFlags);
    }
}
