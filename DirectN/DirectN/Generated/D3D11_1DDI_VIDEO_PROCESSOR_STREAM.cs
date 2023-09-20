// generated from <Windows SDK Path>\um\d3d10umddi.h
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
