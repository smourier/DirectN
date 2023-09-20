// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_VIDEOCONTROL_ACTUAL_FRAME_RATE_S
    {
        public KSIDENTIFIER Property;
        public uint StreamIndex;
        public uint RangeIndex;
        public tagSIZE Dimensions;
        public long CurrentActualFrameRate;
        public long CurrentMaxAvailableFrameRate;
    }
}
