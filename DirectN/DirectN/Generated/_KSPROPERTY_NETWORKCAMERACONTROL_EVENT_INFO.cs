// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(6908,9)
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
