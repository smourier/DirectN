// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(2625,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDICERTIFICATEINFO
    {
        public _D3DDDI_CERTIFICATETYPE CertificateType;
        public _DDIAUTHENTICATEDCHANNELTYPE ChannelType;
        public Guid CryptoSessionType;
    }
}
