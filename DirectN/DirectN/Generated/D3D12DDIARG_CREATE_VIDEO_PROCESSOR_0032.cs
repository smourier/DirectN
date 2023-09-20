// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_VIDEO_PROCESSOR_0032
    {
        public uint NodeMask;
        public D3D12DDI_VIDEO_PROCESS_OUTPUT_STREAM_DESC_0032 OutputStream;
        public IntPtr pInputStreams;
        public uint NumInputStreams;
    }
}
