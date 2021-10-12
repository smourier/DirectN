// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1601,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_PRESENT_0001
    {
        public IntPtr phSurfacesToPresent;
        public uint SurfacesToPresent;
        public D3D10DDI_HRESOURCE hDstResource;
        public uint DstSubResourceIndex;
        public DXGI_DDI_PRESENT_FLAGS Flags;
        public DXGI_DDI_FLIP_INTERVAL_TYPE FlipInterval;
        public uint VidPnSourceID;
        public IntPtr pDirtyRects;
        public uint DirtyRects;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public bool OptimizeForComposition;
    }
}
