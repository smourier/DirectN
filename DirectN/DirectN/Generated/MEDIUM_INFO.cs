// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(6983,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MEDIUM_INFO
    {
        public bool MediaPresent;
        public uint MediaType;
        public bool RecordInhibit;
    }
}
