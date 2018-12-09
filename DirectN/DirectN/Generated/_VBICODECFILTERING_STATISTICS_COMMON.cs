// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(4623,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VBICODECFILTERING_STATISTICS_COMMON
    {
        public uint InputSRBsProcessed;
        public uint OutputSRBsProcessed;
        public uint SRBsIgnored;
        public uint InputSRBsMissing;
        public uint OutputSRBsMissing;
        public uint OutputFailures;
        public uint InternalErrors;
        public uint ExternalErrors;
        public uint InputDiscontinuities;
        public uint DSPFailures;
        public uint TvTunerChanges;
        public uint VBIHeaderChanges;
        public uint LineConfidenceAvg;
        public uint BytesOutput;
    }
}
