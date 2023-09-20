// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DLOCKED_BOX
    {
        public int RowPitch;
        public int SlicePitch;
        public IntPtr pBits;
    }
}
