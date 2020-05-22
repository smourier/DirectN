// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(666,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _IUNKNOWN_LIST
    {
        public IntPtr lpLink;
        public IntPtr lpGuid;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object lpIUnknown;
    }
}
