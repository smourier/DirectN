// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wingdi.h(3389,9)
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
