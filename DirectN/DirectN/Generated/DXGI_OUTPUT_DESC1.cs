// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_6.h(357,9)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct DXGI_OUTPUT_DESC1
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string[] DeviceName;
        public RECT DesktopCoordinates;
        public bool AttachedToDesktop;
        public DXGI_MODE_ROTATION Rotation;
        public IntPtr Monitor;
        public uint BitsPerColor;
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
