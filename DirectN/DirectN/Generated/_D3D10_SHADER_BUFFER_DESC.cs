// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d10shader.h(211,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_BUFFER_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        public _D3D_CBUFFER_TYPE Type;
        public uint Variables;
        public uint Size;
        public uint uFlags;
    }
}
