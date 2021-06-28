// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mmeapi.h(196,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct tagWAVEINCAPSA
    {
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string szPname;
        public uint dwFormats;
        public ushort wChannels;
        public ushort wReserved1;
    }
}
