// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(2630,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDIARG_SIGNATURE_ENTRY
    {
        public int SystemValue;
        public uint Register;
        public byte Mask;
        public int RegisterComponentType;
        public int MinPrecision;
    }
}
