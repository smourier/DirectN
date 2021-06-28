// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(3257,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct _RGNDATA
    {
        public _RGNDATAHEADER rdh;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] 
        public string Buffer;
    }
}
