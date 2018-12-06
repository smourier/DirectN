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
        public IReadOnlyList<DISPLAY_DEVICE> Monitors => UserExtensions.EnumerateDisplayDevices(DeviceName).ToList();
    }
}
