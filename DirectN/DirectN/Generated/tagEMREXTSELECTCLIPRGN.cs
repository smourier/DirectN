// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMREXTSELECTCLIPRGN
    {
        public tagEMR emr;
        public uint cbRgnData;
        public uint iMode;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] RgnData;
    }
}
