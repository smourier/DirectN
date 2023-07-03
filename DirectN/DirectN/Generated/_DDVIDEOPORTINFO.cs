// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\dvp.h(352,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDVIDEOPORTINFO
    {
        public uint dwSize;
        public uint dwOriginX;
        public uint dwOriginY;
        public uint dwVPFlags;
        public tagRECT rCrop;
        public uint dwPrescaleWidth;
        public uint dwPrescaleHeight;
        public IntPtr lpddpfInputFormat;
        public IntPtr lpddpfVBIInputFormat;
        public IntPtr lpddpfVBIOutputFormat;
        public uint dwVBIHeight;
        public IntPtr dwReserved1;
        public IntPtr dwReserved2;
    }
}
