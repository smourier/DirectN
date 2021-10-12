// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(1375,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_PROCESS_REFERENCE_SET
    {
        public uint NumPastFrames;
        public IntPtr ppPastFrames;
        public IntPtr pPastSubresources;
        public uint NumFutureFrames;
        public IntPtr ppFutureFrames;
        public IntPtr pFutureSubresources;
    }
}
