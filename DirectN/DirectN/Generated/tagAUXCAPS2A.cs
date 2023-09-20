// generated from <Windows SDK Path>\um\mmeapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct tagAUXCAPS2A
    {
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string szPname;
        public ushort wTechnology;
        public ushort wReserved1;
        public uint dwSupport;
        public Guid ManufacturerGuid;
        public Guid ProductGuid;
        public Guid NameGuid;
    }
}
