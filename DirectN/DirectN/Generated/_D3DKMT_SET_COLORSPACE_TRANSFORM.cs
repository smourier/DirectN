// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SET_COLORSPACE_TRANSFORM
    {
        public LUID AdapterLuid;
        public uint VidPnTargetId;
        public _D3DDDI_GAMMARAMP_TYPE Type;
        public uint Size;
        public _D3DKMT_SET_COLORSPACE_TRANSFORM__union_0 __union_4;
    }
}
