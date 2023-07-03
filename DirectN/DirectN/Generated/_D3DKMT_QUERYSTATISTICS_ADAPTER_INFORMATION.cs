// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3578,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_ADAPTER_INFORMATION
    {
        public uint NbSegments;
        public uint NodeCount;
        public uint VidPnSourceCount;
        public uint VSyncEnabled;
        public uint TdrDetectedCount;
        public long ZeroLengthDmaBuffers;
        public ulong RestartedPeriod;
        public _D3DKMT_QUERYSTATSTICS_REFERENCE_DMA_BUFFER ReferenceDmaBuffer;
        public _D3DKMT_QUERYSTATSTICS_RENAMING Renaming;
        public _D3DKMT_QUERYSTATSTICS_PREPRATION Preparation;
        public _D3DKMT_QUERYSTATSTICS_PAGING_FAULT PagingFault;
        public _D3DKMT_QUERYSTATSTICS_PAGING_TRANSFER PagingTransfer;
        public _D3DKMT_QUERYSTATSTICS_SWIZZLING_RANGE SwizzlingRange;
        public _D3DKMT_QUERYSTATSTICS_LOCKS Locks;
        public _D3DKMT_QUERYSTATSTICS_ALLOCATIONS Allocations;
        public _D3DKMT_QUERYSTATSTICS_TERMINATIONS Terminations;
        public _D3DKMT_QUERYSTATISTICS_ADAPTER_INFORMATION_FLAGS Flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)] 
        public ulong[] Reserved;
    }
}
