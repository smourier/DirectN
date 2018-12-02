// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mmeapi.h(1903,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct tagMIXERLINEA__struct_0
    {
        public uint dwType;
        public uint dwDeviceID;
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string[] szPname;
    }
}
