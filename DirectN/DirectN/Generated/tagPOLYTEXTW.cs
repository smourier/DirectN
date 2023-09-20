// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagPOLYTEXTW
    {
        public int x;
        public int y;
        public uint n;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string lpstr;
        public uint uiFlags;
        public tagRECT rcl;
        public IntPtr pdx;
    }
}
