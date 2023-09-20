// generated from <Windows SDK Path>\um\d3d12shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D12_SHADER_TYPE_DESC
    {
        public _D3D_SHADER_VARIABLE_CLASS Class;
        public _D3D_SHADER_VARIABLE_TYPE Type;
        public uint Rows;
        public uint Columns;
        public uint Elements;
        public uint Members;
        public uint Offset;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
    }
}
