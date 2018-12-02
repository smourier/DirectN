// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(359,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct DD32BITDRIVERDATA
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string[] szName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string[] szEntryPoint;
        public uint dwContext;
    }
}
