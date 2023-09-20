// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DOCINFOW
    {
        public int cbSize;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string lpszDocName;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string lpszOutput;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string lpszDatatype;
        public uint fwType;
    }
}
