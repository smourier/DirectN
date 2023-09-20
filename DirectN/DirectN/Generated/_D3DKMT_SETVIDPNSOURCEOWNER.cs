// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;
using D3DDDI_VIDEO_PRESENT_SOURCE_ID = System.UInt32;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SETVIDPNSOURCEOWNER
    {
        public uint hDevice;
        public IntPtr pType;
        public IntPtr pVidPnSourceId;
        public uint VidPnSourceCount;
    }
}
