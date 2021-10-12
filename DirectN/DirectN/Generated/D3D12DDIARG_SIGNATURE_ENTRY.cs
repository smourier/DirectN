// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(2040,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_SIGNATURE_ENTRY
    {
        public D3D10_SB_NAME SystemValue;
        public uint Register;
        public byte Mask;
        public D3D10_SB_REGISTER_COMPONENT_TYPE RegisterComponentType;
        public D3D11_SB_OPERAND_MIN_PRECISION MinPrecision;
    }
}
