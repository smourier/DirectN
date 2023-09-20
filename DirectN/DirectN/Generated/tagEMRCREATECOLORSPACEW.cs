// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRCREATECOLORSPACEW
    {
        public tagEMR emr;
        public uint ihCS;
        public tagLOGCOLORSPACEW lcs;
        public uint dwFlags;
        public uint cbData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] Data;
    }
}
