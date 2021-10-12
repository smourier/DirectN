// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(3722,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_AUTHENTICATED_CONFIGURE_OUTPUT
    {
        public D3D11_1DDI_OMAC omac;
        public Guid ConfigureType;
        public IntPtr hChannel;
        public uint SequenceNumber;
        public HRESULT ReturnCode;
    }
}
