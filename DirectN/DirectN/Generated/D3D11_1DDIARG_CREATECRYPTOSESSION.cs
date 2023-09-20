// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDIARG_CREATECRYPTOSESSION
    {
        public Guid CryptoType;
        public Guid DecodeProfile;
        public Guid KeyExchangeType;
    }
}
