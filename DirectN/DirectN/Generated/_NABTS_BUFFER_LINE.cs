// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(4625,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _NABTS_BUFFER_LINE
    {
        public byte Confidence;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)] 
        public byte[] Bytes;
    }
}
