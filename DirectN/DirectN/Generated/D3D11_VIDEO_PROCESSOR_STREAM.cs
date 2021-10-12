// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(10834,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_PROCESSOR_STREAM
    {
        public bool Enable;
        public uint OutputIndex;
        public uint InputFrameOrField;
        public uint PastFrames;
        public uint FutureFrames;
        public IntPtr ppPastSurfaces;
        public IntPtr pInputSurface;
        public IntPtr ppFutureSurfaces;
        public IntPtr ppPastSurfacesRight;
        public IntPtr pInputSurfaceRight;
        public IntPtr ppFutureSurfacesRight;
    }
}
