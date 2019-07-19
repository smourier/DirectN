// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva.h(2349,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPStatusSignalingCmdData
    {
        public Guid rApp;
        public uint dwFlags;
        public uint AvailableTVProtectionStandards;
        public uint ActiveTVProtectionStandard;
        public uint TVType;
        public uint AspectRatioValidMask1;
        public uint AspectRatioData1;
        public uint AspectRatioValidMask2;
        public uint AspectRatioData2;
        public uint AspectRatioValidMask3;
        public uint AspectRatioData3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] ExtendedInfoValidMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] ExtendedInfoData;
    }
}
