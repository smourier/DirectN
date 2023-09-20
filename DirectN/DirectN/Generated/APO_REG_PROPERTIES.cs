// generated from <Windows SDK Path>\um\audioenginebaseapo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct APO_REG_PROPERTIES
    {
        public Guid clsid;
        public APO_FLAG Flags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)] 
        public string szFriendlyName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)] 
        public string szCopyrightInfo;
        public uint u32MajorVersion;
        public uint u32MinorVersion;
        public uint u32MinInputConnections;
        public uint u32MaxInputConnections;
        public uint u32MinOutputConnections;
        public uint u32MaxOutputConnections;
        public uint u32MaxInstances;
        public uint u32NumAPOInterfaces;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public Guid[] iidAPOInterfaceList;
    }
}
