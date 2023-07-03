// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(5047,9)
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
