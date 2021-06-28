// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11shader.h(45,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D11_SIGNATURE_PARAMETER_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string SemanticName;
        public uint SemanticIndex;
        public uint Register;
        public D3D_NAME SystemValueType;
        public D3D_REGISTER_COMPONENT_TYPE ComponentType;
        public byte Mask;
        public byte ReadWriteMask;
        public uint Stream;
        public D3D_MIN_PRECISION MinPrecision;
    }
}
