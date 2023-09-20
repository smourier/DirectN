// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagPOLYTEXTA
    {
        public int x;
        public int y;
        public uint n;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string lpstr;
        public uint uiFlags;
        public tagRECT rcl;
        public IntPtr pdx;
    }
}
