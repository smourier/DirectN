// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _WMUserWebURL
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszDescription;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszURL;
    }
}
