// generated from <Windows SDK Path>\um\d3dumddi.h
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
