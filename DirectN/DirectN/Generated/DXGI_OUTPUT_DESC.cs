// generated from <Windows SDK Path>\shared\dxgi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct DXGI_OUTPUT_DESC
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string DeviceName;
        public tagRECT DesktopCoordinates;
        public bool AttachedToDesktop;
        public DXGI_MODE_ROTATION Rotation;
        public IntPtr Monitor;
    }
}
