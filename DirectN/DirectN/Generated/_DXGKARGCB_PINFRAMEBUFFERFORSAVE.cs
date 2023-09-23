// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_PINFRAMEBUFFERFORSAVE
    {
        public uint PhysicalAdapterIndex;
        public IntPtr CommitSize;
        public IntPtr pMdl;
    }
}
