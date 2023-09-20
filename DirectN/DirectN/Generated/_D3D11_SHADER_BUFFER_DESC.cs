// generated from <Windows SDK Path>\um\d3d11shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D11_SHADER_BUFFER_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        public _D3D_CBUFFER_TYPE Type;
        public uint Variables;
        public uint Size;
        public uint uFlags;
    }
}
