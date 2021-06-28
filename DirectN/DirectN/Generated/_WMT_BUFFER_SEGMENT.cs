// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(1539,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WMT_BUFFER_SEGMENT
    {
        public IntPtr pBuffer;
        public uint cbOffset;
        public uint cbLength;
    }
}
