// generated from <Windows SDK Path>\um\ddrawint.h
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
