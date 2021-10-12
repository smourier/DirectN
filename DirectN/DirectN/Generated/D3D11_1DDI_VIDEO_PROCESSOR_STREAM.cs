// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(3481,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_VIDEO_PROCESSOR_STREAM
    {
        public bool Enable;
        public uint OutputIndex;
        public uint InputFrameOrField;
        public uint PastFrames;
        public uint FutureFrames;
        public IntPtr pPastSurfaces;
        public D3D11_1DDI_HVIDEOPROCESSORINPUTVIEW hInputSurface;
        public IntPtr pFutureSurfaces;
        public IntPtr pPastSurfacesRight;
        public D3D11_1DDI_HVIDEOPROCESSORINPUTVIEW hInputSurfaceRight;
        public IntPtr pFutureSurfacesRight;
    }
}
