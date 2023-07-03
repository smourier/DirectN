// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(1537,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct tagENUMLOGFONTEXW
    {
        public tagLOGFONTW elfLogFont;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string elfFullName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string elfStyle;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string elfScript;
    }
}
