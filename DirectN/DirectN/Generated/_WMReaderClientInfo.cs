// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(1506,9)
using System;
using System.Runtime.InteropServices;
using LPARAM = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WMReaderClientInfo
    {
        public uint cbSize;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char wszLang;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char wszBrowserUserAgent;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char wszBrowserWebPage;
        public ulong qwReserved;
        public IntPtr pReserved;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char wszHostExe;
        public ulong qwHostVersion;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char wszPlayerUserAgent;
    }
}
