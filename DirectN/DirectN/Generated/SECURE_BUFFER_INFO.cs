// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(5007,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SECURE_BUFFER_INFO
    {
        public Guid guidBufferIdentifier;
        public uint cbBufferSize;
        public uint cbCaptured;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public ulong[] ullReserved;
    }
}
