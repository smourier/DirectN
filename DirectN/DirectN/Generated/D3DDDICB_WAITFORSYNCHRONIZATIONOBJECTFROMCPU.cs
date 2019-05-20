// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(3814,9)
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
