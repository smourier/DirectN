// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1859,9)
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
