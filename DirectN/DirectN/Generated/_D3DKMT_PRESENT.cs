// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(618,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PRESENT
    {
        public _D3DKMT_PRESENT__union_0 __union_0;
        public IntPtr hWindow;
        public uint VidPnSourceId;
        public uint hSource;
        public uint hDestination;
        public uint Color;
        public tagRECT DstRect;
        public tagRECT SrcRect;
        public uint SubRectCnt;
        public IntPtr pSrcSubRects;
        public uint PresentCount;
        public D3DDDI_FLIPINTERVAL_TYPE FlipInterval;
        public _D3DKMT_PRESENTFLAGS Flags;
        public uint BroadcastContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public uint[] BroadcastContext;
        public IntPtr PresentLimitSemaphore;
        public _D3DKMT_PRESENTHISTORYTOKEN PresentHistoryToken;
        public IntPtr pPresentRegions;
        public _D3DKMT_PRESENT__union_1 __union_18;
        public uint Duration;
        public IntPtr BroadcastSrcAllocation;
        public IntPtr BroadcastDstAllocation;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public byte bOptimizeForComposition;
    }
}
