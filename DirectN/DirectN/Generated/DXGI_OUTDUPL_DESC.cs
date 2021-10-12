// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dxgi1_2.h(234,9)
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
