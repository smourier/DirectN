// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(7058,9)
using System;
using System.Runtime.InteropServices;
using DXGKCB_PRESENT_DISPLAYONLY_PROGRESS = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_PRESENT_DISPLAYONLY
    {
        public uint VidPnSourceId;
        public IntPtr pSource;
        public uint BytesPerPixel;
        public int Pitch;
        public _D3DKMT_PRESENT_DISPLAY_ONLY_FLAGS Flags;
        public uint NumMoves;
        public IntPtr pMoves;
        public uint NumDirtyRects;
        public IntPtr pDirtyRect;
        public IntPtr pfnPresentDisplayOnlyProgress;
    }
}
