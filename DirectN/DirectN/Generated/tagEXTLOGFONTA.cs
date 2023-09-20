// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEXTLOGFONTA
    {
        public tagLOGFONTA elfLogFont;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public byte[] elfFullName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] elfStyle;
        public uint elfVersion;
        public uint elfStyleSize;
        public uint elfMatch;
        public uint elfReserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte[] elfVendorId;
        public uint elfCulture;
        public tagPANOSE elfPanose;
    }
}
