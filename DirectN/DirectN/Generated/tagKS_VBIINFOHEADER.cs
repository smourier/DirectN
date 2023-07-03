// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(4082,9)
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
