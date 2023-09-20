// generated from <Windows SDK Path>\um\ddraw.h
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
