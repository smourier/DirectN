// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(1070,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDNONLOCALVIDMEMCAPS
    {
        public uint dwSize;
        public uint dwNLVBCaps;
        public uint dwNLVBCaps2;
        public uint dwNLVBCKeyCaps;
        public uint dwNLVBFXCaps;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public uint[] dwNLVBRops;
    }
}
