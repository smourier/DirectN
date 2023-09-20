// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_NONLOCALVIDMEMCAPS
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
