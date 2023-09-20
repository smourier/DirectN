// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_ATTACHLIST = DirectN._DD_ATTACHLIST;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_ATTACHLIST
    {
        public IntPtr lpLink;
        public IntPtr lpAttached;
    }
}
