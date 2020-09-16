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

        public override string ToString() => "Name=" + DeviceName + ", String=" + DeviceString;

        public static DISPLAY_DEVICE Primary => All.FirstOrDefault(d => d.StateFlags.HasFlag(DISPLAY_DEVICE_FLAGS.DISPLAY_DEVICE_PRIMARY_DEVICE));
        public static IEnumerable<DISPLAY_DEVICE> Active => All.Where(d => d.StateFlags.HasFlag(DISPLAY_DEVICE_FLAGS.DISPLAY_DEVICE_ACTIVE));
        public static IEnumerable<DISPLAY_DEVICE> All
        {
            get
            {
                var dd = new DISPLAY_DEVICE();
                dd.cb = Marshal.SizeOf<DISPLAY_DEVICE>();
                int index = 0;
                do
                {
                    if (!EnumDisplayDevices(null, index++, ref dd, 0))
                        break;

                    yield return dd;
                }
                while (true);
            }
        }

        [DllImport("user32", CharSet = CharSet.Unicode)]
        private static extern bool EnumDisplayDevices(string lpDevice, int iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, int dwFlags);
    }
}
