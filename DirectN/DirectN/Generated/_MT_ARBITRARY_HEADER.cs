// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfapi.h(3297,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MT_ARBITRARY_HEADER
    {
        public Guid majortype;
        public Guid subtype;
        public bool bFixedSizeSamples;
        public bool bTemporalCompression;
        public uint lSampleSize;
        public Guid formattype;
    }
}
