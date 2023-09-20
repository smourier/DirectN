// generated from <Windows SDK Path>\um\mfplay.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MFP_STOP_EVENT
    {
        public MFP_EVENT_HEADER header;
        public IntPtr pMediaItem;
    }
}
