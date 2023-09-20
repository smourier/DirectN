// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_HDR_METADATA
    {
        public _D3DDDI_HDR_METADATA_TYPE Type;
        public uint Size;
        public IntPtr pMetaData;
    }
}
