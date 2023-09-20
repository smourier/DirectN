// generated from <Windows SDK Path>\um\wingdi.h
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
