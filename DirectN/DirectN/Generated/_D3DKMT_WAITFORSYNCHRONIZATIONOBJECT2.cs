// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(147,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_WAITFORSYNCHRONIZATIONOBJECT2
    {
        public uint hContext;
        public uint ObjectCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public uint[] ObjectHandleArray;
        public _D3DKMT_WAITFORSYNCHRONIZATIONOBJECT2__union_0 __union_3;
    }
}
