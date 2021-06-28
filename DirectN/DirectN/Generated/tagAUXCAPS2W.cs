// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mmeapi.h(1601,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct tagAUXCAPS2W
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
