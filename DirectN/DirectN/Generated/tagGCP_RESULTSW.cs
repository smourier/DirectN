// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(3612,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagGCP_RESULTSW
    {
        public uint lStructSize;
        [MarshalAs(UnmanagedType.LPWStr)] 
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
