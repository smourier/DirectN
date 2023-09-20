// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OUTDUPL_POINTER_SHAPE_INFO
    {
        public _D3DKMT_OUTDUPL_POINTER_SHAPE_TYPE Type;
        public uint Width;
        public uint Height;
        public uint Pitch;
        public tagPOINT HotSpot;
    }
}
