// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_DeinterlaceCaps
    {
        public uint Size;
        public uint NumPreviousOutputFrames;
        public uint InputPool;
        public uint NumForwardRefSamples;
        public uint NumBackwardRefSamples;
        public uint d3dOutputFormat;
        public _DXVA_VideoProcessCaps VideoProcessingCaps;
        public _DXVA_DeinterlaceTech DeinterlaceTechnology;
    }
}
