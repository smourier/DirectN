// generated from <Windows SDK Path>\um\wingdi.h
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
