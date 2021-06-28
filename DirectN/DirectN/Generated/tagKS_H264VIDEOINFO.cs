// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(4215,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_H264VIDEOINFO
    {
        public ushort wWidth;
        public ushort wHeight;
        public ushort wSARwidth;
        public ushort wSARheight;
        public ushort wProfile;
        public byte bLevelIDC;
        public ushort wConstrainedToolset;
        public uint bmSupportedUsages;
        public ushort bmCapabilities;
        public uint bmSVCCapabilities;
        public uint bmMVCCapabilities;
        public uint dwFrameInterval;
        public byte bMaxCodecConfigDelay;
        public byte bmSupportedSliceModes;
        public byte bmSupportedSyncFrameTypes;
        public byte bResolutionScaling;
        public byte bSimulcastSupport;
        public byte bmSupportedRateControlModes;
        public ushort wMaxMBperSecOneResolutionNoScalability;
        public ushort wMaxMBperSecTwoResolutionsNoScalability;
        public ushort wMaxMBperSecThreeResolutionsNoScalability;
        public ushort wMaxMBperSecFourResolutionsNoScalability;
        public ushort wMaxMBperSecOneResolutionTemporalScalability;
        public ushort wMaxMBperSecTwoResolutionsTemporalScalablility;
        public ushort wMaxMBperSecThreeResolutionsTemporalScalability;
        public ushort wMaxMBperSecFourResolutionsTemporalScalability;
        public ushort wMaxMBperSecOneResolutionTemporalQualityScalability;
        public ushort wMaxMBperSecTwoResolutionsTemporalQualityScalability;
        public ushort wMaxMBperSecThreeResolutionsTemporalQualityScalablity;
        public ushort wMaxMBperSecFourResolutionsTemporalQualityScalability;
        public ushort wMaxMBperSecOneResolutionTemporalSpatialScalability;
        public ushort wMaxMBperSecTwoResolutionsTemporalSpatialScalability;
        public ushort wMaxMBperSecThreeResolutionsTemporalSpatialScalablity;
        public ushort wMaxMBperSecFourResolutionsTemporalSpatialScalability;
        public ushort wMaxMBperSecOneResolutionFullScalability;
        public ushort wMaxMBperSecTwoResolutionsFullScalability;
        public ushort wMaxMBperSecThreeResolutionsFullScalability;
        public ushort wMaxMBperSecFourResolutionsFullScalability;
    }
}
