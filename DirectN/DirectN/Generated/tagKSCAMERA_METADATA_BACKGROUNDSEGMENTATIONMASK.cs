// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_METADATA_BACKGROUNDSEGMENTATIONMASK
    {
        public tagKSCAMERA_METADATA_ITEMHEADER Header;
        public tagRECT MaskCoverageBoundingBox;
        public tagSIZE MaskResolution;
        public tagRECT ForegroundBoundingBox;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] MaskData;
    }
}
