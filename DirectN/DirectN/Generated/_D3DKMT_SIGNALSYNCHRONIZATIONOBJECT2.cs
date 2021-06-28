// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(169,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SIGNALSYNCHRONIZATIONOBJECT2
    {
        public uint hContext;
        public uint ObjectCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public uint[] ObjectHandleArray;
        public _D3DDDICB_SIGNALFLAGS Flags;
        public uint BroadcastContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public uint[] BroadcastContext;
        public _D3DKMT_SIGNALSYNCHRONIZATIONOBJECT2__union_0 __union_6;
    }
}
