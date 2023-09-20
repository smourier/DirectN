// generated from <Windows SDK Path>\um\d3d10umddi.h
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
