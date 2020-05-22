// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\opmapi.h(345,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _OPM_ACP_AND_CGMSA_SIGNALING
    {
        public _OPM_RANDOM_NUMBER rnRandomNumber;
        public uint ulStatusFlags;
        public uint ulAvailableTVProtectionStandards;
        public uint ulActiveTVProtectionStandard;
        public uint ulReserved;
        public uint ulAspectRatioValidMask1;
        public uint ulAspectRatioData1;
        public uint ulAspectRatioValidMask2;
        public uint ulAspectRatioData2;
        public uint ulAspectRatioValidMask3;
        public uint ulAspectRatioData3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] ulReserved2;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] ulReserved3;
    }
}
