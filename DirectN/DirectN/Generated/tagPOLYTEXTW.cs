﻿// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(3444,9)
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
