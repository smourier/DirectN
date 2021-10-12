// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawint.h(434,9)
using System;
using System.Runtime.InteropServices;
using PDD_FLIPTOGDISURFACE = System.IntPtr;
using PDD_FREEDRIVERMEMORY = System.IntPtr;
using PDD_SETEXCLUSIVEMODE = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_NTCALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr FreeDriverMemory;
        public IntPtr SetExclusiveMode;
        public IntPtr FlipToGDISurface;
    }
}
