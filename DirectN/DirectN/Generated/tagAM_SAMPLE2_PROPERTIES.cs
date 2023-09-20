// generated from <Windows SDK Path>\um\strmif.h
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
