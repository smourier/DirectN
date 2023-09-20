// generated from <Windows SDK Path>\um\d3d10shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SIGNATURE_PARAMETER_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string SemanticName;
        public uint SemanticIndex;
        public uint Register;
        public D3D_NAME SystemValueType;
        public D3D_REGISTER_COMPONENT_TYPE ComponentType;
        public byte Mask;
        public byte ReadWriteMask;
    }
}
