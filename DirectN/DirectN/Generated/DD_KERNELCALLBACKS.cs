// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawint.h(604,9)
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
