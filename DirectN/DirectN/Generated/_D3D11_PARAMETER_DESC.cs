// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11shader.h(218,9)
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
