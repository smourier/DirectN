// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _tagKSTOPOLOGY_ENDPOINTID
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string TopologyName;
        public uint PinId;
    }
}
