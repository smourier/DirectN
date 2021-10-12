// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(1074,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVADDI_VIDEODESC
    {
        public uint SampleWidth;
        public uint SampleHeight;
        public _DXVADDI_EXTENDEDFORMAT SampleFormat;
        public _D3DDDIFORMAT Format;
        public _DXVADDI_FREQUENCY InputSampleFreq;
        public _DXVADDI_FREQUENCY OutputFrameFreq;
        public uint UABProtectionLevel;
        public uint Reserved;
    }
}
