// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11shadertracing.h(113,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_COMPUTE_SHADER_TRACE_DESC
    {
        public ulong Invocation;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public uint[] ThreadIDInGroup;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public uint[] ThreadGroupID;
    }
}
