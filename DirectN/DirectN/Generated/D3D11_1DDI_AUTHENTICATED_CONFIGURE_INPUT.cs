// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(3708,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_AUTHENTICATED_CONFIGURE_INPUT
    {
        public D3D11_1DDI_OMAC omac;
        public Guid ConfigureType;
        public IntPtr hChannel;
        public uint SequenceNumber;
    }
}
