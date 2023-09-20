// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_VBIINFOHEADER
    {
        public uint StartLine;
        public uint EndLine;
        public uint SamplingFrequency;
        public uint MinLineStartTime;
        public uint MaxLineStartTime;
        public uint ActualLineStartTime;
        public uint ActualLineEndTime;
        public uint VideoStandard;
        public uint SamplesPerLine;
        public uint StrideInBytes;
        public uint BufferSize;
    }
}
