// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11shader.h(171,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D11_LIBRARY_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Creator;
        public uint Flags;
        public uint FunctionCount;
    }
}
