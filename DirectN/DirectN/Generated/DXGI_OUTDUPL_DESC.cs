// generated from <Windows SDK Path>\shared\dxgi1_2.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_OUTDUPL_DESC
    {
        public DXGI_MODE_DESC ModeDesc;
        public DXGI_MODE_ROTATION Rotation;
        public bool DesktopImageInSystemMemory;
    }
}
