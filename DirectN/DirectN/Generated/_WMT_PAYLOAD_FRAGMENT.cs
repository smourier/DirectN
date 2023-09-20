// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WMT_PAYLOAD_FRAGMENT
    {
        public uint dwPayloadIndex;
        public _WMT_BUFFER_SEGMENT segmentData;
    }
}
