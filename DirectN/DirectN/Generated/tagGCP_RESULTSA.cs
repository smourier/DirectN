// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagGCP_RESULTSA
    {
        public uint lStructSize;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string lpOutString;
        public IntPtr lpOrder;
        public IntPtr lpDx;
        public IntPtr lpCaretPos;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string lpClass;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string lpGlyphs;
        public uint nGlyphs;
        public int nMaxFit;
    }
}
