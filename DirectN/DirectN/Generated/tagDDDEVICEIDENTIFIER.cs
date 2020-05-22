// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddraw.h(827,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct tagDDDEVICEIDENTIFIER
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)] 
        public string szDriver;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)] 
        public string szDescription;
        public long liDriverVersion;
        public uint dwVendorId;
        public uint dwDeviceId;
        public uint dwSubSysId;
        public uint dwRevision;
        public Guid guidDeviceIdentifier;
    }
}
