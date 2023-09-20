// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_PROCESSOR_SIZE_DATA_0072
    {
        public uint NodeMask;
        public D3D12DDI_VIDEO_PROCESS_OUTPUT_STREAM_DESC_0032 OutputStream;
        public IntPtr pInputStreams;
        public uint NumInputStreams;
        public bool Protected;
        public ulong MemoryPoolL0Size;
        public ulong MemoryPoolL1Size;
    }
}
