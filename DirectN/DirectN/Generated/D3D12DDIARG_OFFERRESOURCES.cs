// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_OFFERRESOURCES
    {
        public uint NumObjects;
        public IntPtr pObjects;
        public _D3DDDI_OFFER_PRIORITY Priority;
    }
}
