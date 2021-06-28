// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxcapi.h(173,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DxcDefine
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Value;
    }
}
