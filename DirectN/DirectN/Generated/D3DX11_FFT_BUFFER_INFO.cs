// generated from <Windows SDK Path>\um\d3dcsx.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DX11_FFT_BUFFER_INFO
    {
        public uint NumTempBufferSizes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] TempBufferFloatSizes;
        public uint NumPrecomputeBufferSizes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] PrecomputeBufferFloatSizes;
    }
}
