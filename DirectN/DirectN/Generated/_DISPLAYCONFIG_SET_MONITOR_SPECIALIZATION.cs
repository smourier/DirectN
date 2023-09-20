// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _DISPLAYCONFIG_SET_MONITOR_SPECIALIZATION
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
        public _DISPLAYCONFIG_SET_MONITOR_SPECIALIZATION__union_0 __union_1;
        public Guid specializationType;
        public Guid specializationSubType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string specializationApplicationName;
    }
}
