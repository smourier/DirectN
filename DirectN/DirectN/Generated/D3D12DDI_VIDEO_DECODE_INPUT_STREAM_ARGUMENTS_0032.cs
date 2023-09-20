// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS_0032
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)] 
        public D3D12DDI_VIDEO_DECODE_FRAME_ARGUMENT_0020[] FrameArguments;
        public uint NumFrameArguments;
        public D3D12DDI_VIDEO_DECODE_REFERENCE_FRAMES_0032 ReferenceFrames;
        public D3D12DDI_VIDEO_DECODE_COMPRESSED_BITSTREAM_0032 CompressedBitstream;
        public D3D12DDI_VIDEO_DECODE_DECRYPTION_ARGUMENTS_0030 DecryptionParameters;
        public D3D12DDI_HVIDEODECODERHEAP_0032 hDrvVideoDecoderHeap;
    }
}
