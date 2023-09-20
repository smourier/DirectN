// generated from <Windows SDK Path>\shared\ksmedia.h
using System;

namespace DirectN
{
    [Flags]
    public enum MetadataId
    {
        MetadataId_Standard_Start = 0x00000001,
        MetadataId_PhotoConfirmation = 0x00000001,
        MetadataId_UsbVideoHeader = 0x00000002,
        MetadataId_CaptureStats = 0x00000003,
        MetadataId_CameraExtrinsics = 0x00000004,
        MetadataId_CameraIntrinsics = 0x00000005,
        MetadataId_FrameIllumination = 0x00000006,
        MetadataId_DigitalWindow = 0x00000007,
        MetadataId_BackgroundSegmentationMask = 0x00000008,
        MetadataId_Standard_End = 0x00000008,
        MetadataId_Custom_Start = unchecked((int)0x80000000),
    }
}
