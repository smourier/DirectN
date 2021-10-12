// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12047,9)
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
