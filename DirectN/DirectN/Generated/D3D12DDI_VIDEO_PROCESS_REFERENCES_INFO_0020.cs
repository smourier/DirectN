// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_PROCESS_REFERENCES_INFO_0020
    {
        public uint NumPastFrames;
        public IntPtr hDrvPastFrames;
        public IntPtr pPastSubresources;
        public uint NumFutureFrames;
        public IntPtr hDrvFutureFrames;
        public IntPtr pFutureSubresources;
    }
}
