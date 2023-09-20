// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CHANGESURFACEPOINTER
    {
        public IntPtr hDC;
        public IntPtr hBitmap;
        public IntPtr pSurfacePointer;
        public uint Width;
        public uint Height;
        public uint Pitch;
    }
}
