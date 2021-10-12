// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(4720,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VBICODECFILTERING_STATISTICS_NABTS
    {
        public _VBICODECFILTERING_STATISTICS_COMMON Common;
        public uint FECBundleBadLines;
        public uint FECQueueOverflows;
        public uint FECCorrectedLines;
        public uint FECUncorrectableLines;
        public uint BundlesProcessed;
        public uint BundlesSent2IP;
        public uint FilteredLines;
    }
}
