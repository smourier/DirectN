// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(6846,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WNF_KSCAMERA_STREAMSTATE_INFO
    {
        public uint ProcessId;
        public uint SessionId;
        public uint StreamState;
        public uint Reserved;
    }
}
