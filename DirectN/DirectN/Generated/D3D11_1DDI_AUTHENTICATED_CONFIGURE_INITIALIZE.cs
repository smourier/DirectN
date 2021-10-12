// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(3731,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_AUTHENTICATED_CONFIGURE_INITIALIZE
    {
        public D3D11_1DDI_AUTHENTICATED_CONFIGURE_INPUT Parameters;
        public uint StartSequenceQuery;
        public uint StartSequenceConfigure;
    }
}
