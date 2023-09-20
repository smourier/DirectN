// generated from <Windows SDK Path>\um\mmeapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct tagMIXERCAPS2W
    {
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string szPname;
        public uint fdwSupport;
        public uint cDestinations;
        public Guid ManufacturerGuid;
        public Guid ProductGuid;
        public Guid NameGuid;
    }
}
