// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _AMCOPPSignature
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public byte[] Signature;
    }
}
