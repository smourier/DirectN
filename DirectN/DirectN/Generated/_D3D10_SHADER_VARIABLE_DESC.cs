// generated from <Windows SDK Path>\um\d3d10shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_VARIABLE_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        public uint StartOffset;
        public uint Size;
        public uint uFlags;
        public IntPtr DefaultValue;
    }
}
