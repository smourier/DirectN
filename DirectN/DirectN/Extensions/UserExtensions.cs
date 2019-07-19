using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class UserExtensions
    {
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal static extern bool EnumDisplayDevices([MarshalAs(UnmanagedType.LPWStr)] string lpDevice, int iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, EDD_FLAGS dwFlags);

        public static string GetDisplayDeviceName(string deviceName) => GetDisplayDevice(deviceName)?.DeviceName;
        public static DISPLAY_DEVICE? GetDisplayDevice(string deviceName)
        {
            if (deviceName == null)
                throw new ArgumentNullException(nameof(deviceName));

            var dd = new DISPLAY_DEVICE();
            dd.cb = Marshal.SizeOf<DISPLAY_DEVICE>();
            if (!EnumDisplayDevices(deviceName, 0, ref dd, 0))
                return null;

            return dd;
        }

        public static IEnumerable<DISPLAY_DEVICE> EnumerateDisplayDevices(string deviceName = null, EDD_FLAGS flags = EDD_FLAGS.EDD_NONE)
        {
            int i = 0;
            do
            {
                var dd = new DISPLAY_DEVICE();
                dd.cb = Marshal.SizeOf<DISPLAY_DEVICE>();
                if (!EnumDisplayDevices(deviceName, i++, ref dd, flags))
                    yield break;

                yield return dd;
            }
            while (true);
        }
    }
}
