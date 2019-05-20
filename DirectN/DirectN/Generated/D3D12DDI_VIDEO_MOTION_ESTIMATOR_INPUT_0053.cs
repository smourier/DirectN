// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(9855,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_MOTION_ESTIMATOR_INPUT_0053
    {
        public D3D10DDI_HRESOURCE hDrvInputTexture2D;
        public uint InputSubresourceIndex;
        public D3D10DDI_HRESOURCE hDrvReferenceTexture2D;
        public uint ReferenceSubresourceIndex;
        public D3D12DDI_HVIDEOMOTIONVECTORHEAP_0053 hDrvPreviousMotionVectorHeap;
    }
}
