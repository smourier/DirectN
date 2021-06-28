// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(1505,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagENUMLOGFONTA
    {
        public tagLOGFONTA elfLogFont;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public byte[] elfFullName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] elfStyle;
    }
}
