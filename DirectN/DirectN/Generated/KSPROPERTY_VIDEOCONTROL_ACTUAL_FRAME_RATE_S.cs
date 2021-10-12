// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(7435,9)
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
