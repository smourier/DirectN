// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(19854,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VMRVideoDesc
    {
        public uint dwSize;
        public uint dwSampleWidth;
        public uint dwSampleHeight;
        public bool SingleFieldPerSample;
        public uint dwFourCC;
        public _VMRFrequency InputSampleFreq;
        public _VMRFrequency OutputFrameFreq;
    }
}
