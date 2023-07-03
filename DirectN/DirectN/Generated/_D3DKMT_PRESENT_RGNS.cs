// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(679,9)
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
