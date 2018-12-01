// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(3017,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagAM_SAMPLE2_PROPERTIES
    {
        public uint cbData;
        public uint dwTypeSpecificFlags;
        public uint dwSampleFlags;
        public int lActual;
        public long tStart;
        public long tStop;
        public uint dwStreamId;
        public IntPtr pMediaType;
        public IntPtr pbBuffer;
        public int cbBuffer;
    }
}
