// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dxgitype.h(43,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_GAMMA_CONTROL
    {
        public DXGI_RGB Scale;
        public DXGI_RGB Offset;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025)] 
        public DXGI_RGB[] GammaCurve;
    }
}
