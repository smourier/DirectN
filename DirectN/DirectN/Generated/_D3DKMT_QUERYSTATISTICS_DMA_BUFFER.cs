// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_DMA_BUFFER
    {
        public _D3DKMT_QUERYSTATISTICS_COUNTER Size;
        public uint AllocationListBytes;
        public uint PatchLocationListBytes;
    }
}
