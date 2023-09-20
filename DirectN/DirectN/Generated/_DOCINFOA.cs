// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DOCINFOA
    {
        public int cbSize;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string lpszDocName;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string lpszOutput;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string lpszDatatype;
        public uint fwType;
    }
}
