// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(1552,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WMT_FILESINK_DATA_UNIT
    {
        public _WMT_BUFFER_SEGMENT packetHeaderBuffer;
        public uint cPayloads;
        public IntPtr pPayloadHeaderBuffers;
        public uint cPayloadDataFragments;
        public IntPtr pPayloadDataFragments;
    }
}
