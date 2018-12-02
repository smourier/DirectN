// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mmeapi.h(2349,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct tagMIXERCONTROLDETAILS_LISTTEXTA
    {
        public uint dwParam1;
        public uint dwParam2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string[] szName;
    }
}
