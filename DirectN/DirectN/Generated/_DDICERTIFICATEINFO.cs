// generated from <Windows SDK Path>\um\d3dumddi.h
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
