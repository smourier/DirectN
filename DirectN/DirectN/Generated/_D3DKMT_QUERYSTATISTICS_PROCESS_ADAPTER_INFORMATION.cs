// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3689,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_PROCESS_ADAPTER_INFORMATION
    {
        public uint NbSegments;
        public uint NodeCount;
        public uint VidPnSourceCount;
        public uint VirtualMemoryUsage;
        public _D3DKMT_QUERYSTATISTICS_DMA_BUFFER DmaBuffer;
        public _D3DKMT_QUERYSTATISTICS_COMMITMENT_DATA CommitmentData;
        public _D3DKMT_QUERYSTATISTICS_POLICY _Policy;
        public _D3DKMT_QUERYSTATISTICS_PROCESS_INTERFERENCE_COUNTERS ProcessInterferenceCounters;
        public _D3DKMT_CLIENTHINT ClientHint;
    }
}
