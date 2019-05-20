// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11shadertracing.h(175,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_TRACE_VALUE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] Bits;
        public byte ValidMask;
    }
}
