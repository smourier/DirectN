// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(2023,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_SIGNATURE_ENTRY
    {
        public int SystemValue;
        public uint Register;
        public byte Mask;
        public int RegisterComponentType;
        public int MinPrecision;
    }
}
