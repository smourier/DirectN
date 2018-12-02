// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mmeapi.h(1000,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct midihdr_tag
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string lpData;
        public uint dwBufferLength;
        public uint dwBytesRecorded;
        public IntPtr dwUser;
        public uint dwFlags;
        public IntPtr lpNext;
        public IntPtr reserved;
        public uint dwOffset;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public IntPtr[] dwReserved;
    }
}
