// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(907,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_3X4_COLORSPACE_TRANSFORM
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)] 
        public float[] ColorMatrix3x4;
        public float ScalarMultiplier;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4096)] 
        public D3DDDI_DXGI_RGB[] LookupTable1D;
    }
}
