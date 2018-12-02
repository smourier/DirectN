// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12shader.h(224,9)
using System;
using System.Runtime.InteropServices;
using D3D_PARAMETER_FLAGS = DirectN._D3D_PARAMETER_FLAGS;
using D3D_SHADER_VARIABLE_CLASS = DirectN._D3D_SHADER_VARIABLE_CLASS;
using D3D_SHADER_VARIABLE_TYPE = DirectN._D3D_SHADER_VARIABLE_TYPE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D12_PARAMETER_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string SemanticName;
        public D3D_SHADER_VARIABLE_TYPE Type;
        public D3D_SHADER_VARIABLE_CLASS Class;
        public uint Rows;
        public uint Columns;
        public D3D_INTERPOLATION_MODE InterpolationMode;
        public D3D_PARAMETER_FLAGS Flags;
        public uint FirstInRegister;
        public uint FirstInComponent;
        public uint FirstOutRegister;
        public uint FirstOutComponent;
    }
}
