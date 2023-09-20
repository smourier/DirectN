// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHALKERNELCB_SYNCSURFACE = System.IntPtr;
using LPDDHALKERNELCB_SYNCVIDEOPORT = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DDKERNELCALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr SyncSurfaceData;
        public IntPtr SyncVideoPortData;
    }
}
