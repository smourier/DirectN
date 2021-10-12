// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(6602,9)
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
