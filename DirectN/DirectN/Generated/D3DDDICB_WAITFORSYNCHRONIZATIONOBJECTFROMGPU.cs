// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(3835,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDICB_WAITFORSYNCHRONIZATIONOBJECTFROMGPU
    {
        public IntPtr hContext;
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public D3DDDICB_WAITFORSYNCHRONIZATIONOBJECTFROMGPU__union_0 __union_3;
    }
}
