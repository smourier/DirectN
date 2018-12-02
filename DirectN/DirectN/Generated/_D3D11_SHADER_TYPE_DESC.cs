// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11shader.h(84,9)
using System;
using System.Runtime.InteropServices;
using D3D_SHADER_VARIABLE_CLASS = DirectN._D3D_SHADER_VARIABLE_CLASS;
using D3D_SHADER_VARIABLE_TYPE = DirectN._D3D_SHADER_VARIABLE_TYPE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D11_SHADER_TYPE_DESC
    {
        public D3D_SHADER_VARIABLE_CLASS Class;
        public D3D_SHADER_VARIABLE_TYPE Type;
        public uint Rows;
        public uint Columns;
        public uint Elements;
        public uint Members;
        public uint Offset;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
    }
}
