// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dukmdt.h(1034,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_GAMMA_RAMP_DXGI_1
    {
        public D3DDDI_DXGI_RGB Scale;
        public D3DDDI_DXGI_RGB Offset;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025)] 
        public D3DDDI_DXGI_RGB[] GammaCurve;
    }
}
