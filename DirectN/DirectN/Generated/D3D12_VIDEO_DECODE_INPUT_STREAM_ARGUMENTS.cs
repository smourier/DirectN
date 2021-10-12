// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(1079,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS
    {
        public uint NumFrameArguments;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)] 
        public D3D12_VIDEO_DECODE_FRAME_ARGUMENT[] FrameArguments;
        public D3D12_VIDEO_DECODE_REFERENCE_FRAMES ReferenceFrames;
        public D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM CompressedBitstream;
        public IntPtr pHeap;
    }
}
