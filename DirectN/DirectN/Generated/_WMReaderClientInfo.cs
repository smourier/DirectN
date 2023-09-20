// generated from <Windows SDK Path>\um\wmsdkidl.h
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
        public IntPtr wszLang;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public IntPtr wszBrowserUserAgent;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public IntPtr wszBrowserWebPage;
        public ulong qwReserved;
        public IntPtr pReserved;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public IntPtr wszHostExe;
        public ulong qwHostVersion;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public IntPtr wszPlayerUserAgent;
    }
}
