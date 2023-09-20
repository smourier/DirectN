// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PRESENT_MULTIPLANE_OVERLAY3
    {
        public uint hAdapter;
        public uint ContextCount;
        public IntPtr pContextList;
        public uint VidPnSourceId;
        public uint PresentCount;
        public _D3DKMT_PRESENT_MULTIPLANE_OVERLAY_FLAGS Flags;
        public uint PresentPlaneCount;
        public IntPtr ppPresentPlanes;
        public IntPtr pPostComposition;
        public uint Duration;
        public _D3DDDI_HDR_METADATA_TYPE HDRMetaDataType;
        public uint HDRMetaDataSize;
        public IntPtr pHDRMetaData;
        public uint BoostRefreshRateMultiplier;
    }
}
