using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_OUTDUPL_DESC
    {
        public DXGI_MODE_DESC ModeDesc;
        public DXGI_MODE_ROTATION Rotation;
        public bool DesktopImageInSystemMemory;
    }
}
