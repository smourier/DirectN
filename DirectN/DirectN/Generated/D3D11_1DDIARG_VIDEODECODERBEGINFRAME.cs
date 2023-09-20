// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDIARG_VIDEODECODERBEGINFRAME
    {
        public D3D11_1DDI_HVIDEODECODEROUTPUTVIEW hOutputView;
        public IntPtr pContentKey;
        public uint ContentKeySize;
    }
}
