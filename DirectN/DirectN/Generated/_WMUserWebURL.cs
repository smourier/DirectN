// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(1606,9)
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
