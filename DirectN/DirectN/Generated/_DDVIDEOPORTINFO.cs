// generated from <Windows SDK Path>\um\dvp.h
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
