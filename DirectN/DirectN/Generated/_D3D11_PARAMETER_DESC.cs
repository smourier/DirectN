// generated from <Windows SDK Path>\um\d3d11shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D11_PARAMETER_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string SemanticName;
        public _D3D_SHADER_VARIABLE_TYPE Type;
        public _D3D_SHADER_VARIABLE_CLASS Class;
        public uint Rows;
        public uint Columns;
        public D3D_INTERPOLATION_MODE InterpolationMode;
        public _D3D_PARAMETER_FLAGS Flags;
        public uint FirstInRegister;
        public uint FirstInComponent;
        public uint FirstOutRegister;
        public uint FirstOutComponent;
    }
}
