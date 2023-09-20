// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GET_POST_COMPOSITION_CAPS
    {
        public uint hAdapter;
        public uint VidPnSourceId;
        public float MaxStretchFactor;
        public float MaxShrinkFactor;
    }
}
