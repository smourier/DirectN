// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva2api.h(317,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_VideoDesc
    {
        public uint SampleWidth;
        public uint SampleHeight;
        public _DXVA2_ExtendedFormat SampleFormat;
        public int Format;
        public _DXVA2_Frequency InputSampleFreq;
        public _DXVA2_Frequency OutputFrameFreq;
        public uint UABProtectionLevel;
        public uint Reserved;
    }
}
