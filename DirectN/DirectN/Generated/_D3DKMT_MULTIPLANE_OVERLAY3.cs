// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1006,9)
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
    }
}
