// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(3776,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_WAITFORSYNCHRONIZATIONOBJECT2
    {
        public IntPtr hContext;
        public uint ObjectCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public uint[] ObjectHandleArray;
        public ulong FenceValue;
    }
}
