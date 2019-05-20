// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ocidl.h(461,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagCONNECTDATA
    {
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object pUnk;
        public uint dwCookie;
    }
}
