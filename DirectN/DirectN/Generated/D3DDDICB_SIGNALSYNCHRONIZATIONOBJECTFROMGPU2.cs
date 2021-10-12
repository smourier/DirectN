// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(3894,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDICB_SIGNALSYNCHRONIZATIONOBJECTFROMGPU2
    {
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public _D3DDDICB_SIGNALFLAGS Flags;
        public uint BroadcastContextCount;
        public IntPtr BroadcastContextArray;
        public D3DDDICB_SIGNALSYNCHRONIZATIONOBJECTFROMGPU2__union_0 __union_5;
    }
}
