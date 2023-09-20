// generated from <Windows SDK Path>\um\wmsdkidl.h
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
