// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wingdi.h(1512,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct tagENUMLOGFONTW
    {
        public tagLOGFONTW elfLogFont;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string elfFullName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string elfStyle;
    }
}
