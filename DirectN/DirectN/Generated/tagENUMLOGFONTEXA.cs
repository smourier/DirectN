// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagENUMLOGFONTEXA
    {
        public tagLOGFONTA elfLogFont;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public byte[] elfFullName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] elfStyle;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] elfScript;
    }
}
