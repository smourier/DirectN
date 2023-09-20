// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDICB_WAITFORSYNCHRONIZATIONOBJECTFROMCPU
    {
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public IntPtr FenceValueArray;
        public IntPtr hAsyncEvent;
        public _D3DDDI_WAITFORSYNCHRONIZATIONOBJECTFROMCPU_FLAGS Flags;
    }
}
