// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SCHEDULING_LOG_HEADER
    {
        public _DXGK_SCHEDULING_LOG_HEADER__union_0 __union_0;
        public ulong NumberOfEntries;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public ulong[] Reserved;
    }
}
