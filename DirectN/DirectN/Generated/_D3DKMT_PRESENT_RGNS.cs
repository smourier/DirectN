// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PRESENT_RGNS
    {
        public uint DirtyRectCount;
        public IntPtr pDirtyRects;
        public uint MoveRectCount;
        public IntPtr pMoveRects;
    }
}
