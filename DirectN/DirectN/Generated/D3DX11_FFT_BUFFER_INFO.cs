// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dcsx.h(310,9)
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
