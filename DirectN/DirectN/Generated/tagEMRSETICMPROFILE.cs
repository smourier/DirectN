// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRSETICMPROFILE
    {
        public tagEMR emr;
        public uint dwFlags;
        public uint cbName;
        public uint cbData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] Data;
    }
}
