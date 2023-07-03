// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(3225,9)
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
