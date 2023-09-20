// generated from <Windows SDK Path>\um\d3dcsx.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DX11_FFT_DESC
    {
        public uint NumDimensions;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public uint[] ElementLengths;
        public uint DimensionMask;
        public D3DX11_FFT_DATA_TYPE Type;
    }
}
