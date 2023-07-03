// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(4684,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WST_BUFFER_LINE
    {
        public byte Confidence;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 42)] 
        public byte[] Bytes;
    }
}
