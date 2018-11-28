using System.Runtime.InteropServices;

namespace DirectN
{
    // dxgi1_6.h
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_OUTPUT_DESC1
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;
        public RECT DesktopCoordinates;
        public bool AttachedToDesktop;
        public DXGI_MODE_ROTATION Rotation;
        public int Monitor;
        public int BitsPerColor;
        public DXGI_COLOR_SPACE_TYPE ColorSpace;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] RedPrimary;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] GreenPrimary;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] BluePrimary;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] WhitePoint;
        public float MinLuminance;
        public float MaxLuminance;
        public float MaxFullFrameLuminance;
    }
}
