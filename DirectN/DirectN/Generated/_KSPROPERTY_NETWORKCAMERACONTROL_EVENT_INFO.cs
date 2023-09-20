// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _KSPROPERTY_NETWORKCAMERACONTROL_EVENT_INFO
    {
        public tagKSCAMERA_METADATA_ITEMHEADER Header;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] 
        public string EventFilter;
    }
}
