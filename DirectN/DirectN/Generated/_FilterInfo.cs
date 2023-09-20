// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _FilterInfo
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string achName;
        public IntPtr pGraph;
    }
}
