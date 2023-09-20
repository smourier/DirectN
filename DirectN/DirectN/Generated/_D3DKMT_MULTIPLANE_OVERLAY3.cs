// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_MULTIPLANE_OVERLAY3
    {
        public uint LayerIndex;
        public _D3DKMT_PLANE_SPECIFIC_INPUT_FLAGS InputFlags;
        public D3DDDI_FLIPINTERVAL_TYPE FlipInterval;
        public uint MaxImmediateFlipLine;
        public uint AllocationCount;
        public IntPtr pAllocationList;
        public uint DriverPrivateDataSize;
        public IntPtr pDriverPrivateData;
        public IntPtr pPlaneAttributes;
        public uint hFlipToFence;
        public uint hFlipAwayFence;
        public ulong FlipToFenceValue;
        public ulong FlipAwayFenceValue;
    }
}
