// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dcsx.h(293,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DX11_FFT_DESC
    {
        public uint NumDimensions;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public uint ElementLengths;
        public uint DimensionMask;
        public D3DX11_FFT_DATA_TYPE Type;
    }
}
