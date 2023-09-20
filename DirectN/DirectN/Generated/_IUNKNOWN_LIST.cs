// generated from <Windows SDK Path>\um\ddrawi.h
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
