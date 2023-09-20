// generated from <Windows SDK Path>\um\d3d12video.h
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
