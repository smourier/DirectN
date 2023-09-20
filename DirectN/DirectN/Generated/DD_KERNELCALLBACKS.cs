// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_KERNELCB_SYNCSURFACE = System.IntPtr;
using PDD_KERNELCB_SYNCVIDEOPORT = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DD_KERNELCALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr SyncSurfaceData;
        public IntPtr SyncVideoPortData;
    }
}
