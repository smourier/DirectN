// generated from <Windows SDK Path>\shared\d3dukmdt.h
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
