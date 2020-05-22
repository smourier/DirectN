// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(987,9)
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
