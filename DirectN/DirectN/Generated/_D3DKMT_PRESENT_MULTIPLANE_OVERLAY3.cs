// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1043,9)
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
    }
}
