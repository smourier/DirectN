// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(17408,9)
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
