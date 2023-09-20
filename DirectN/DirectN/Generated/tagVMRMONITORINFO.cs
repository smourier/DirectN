// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct tagVMRMONITORINFO
    {
        public tagVMRGUID guid;
        public tagRECT rcMonitor;
        public IntPtr hMon;
        public uint dwFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string szDevice;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)] 
        public string szDescription;
        public long liDriverVersion;
        public uint dwVendorId;
        public uint dwDeviceId;
        public uint dwSubSysId;
        public uint dwRevision;
    }
}
