// generated from <Windows SDK Path>\shared\dxgitype.h
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
