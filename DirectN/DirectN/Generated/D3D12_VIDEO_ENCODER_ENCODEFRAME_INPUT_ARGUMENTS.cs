// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(7015,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS
    {
        public D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC SequenceControlDesc;
        public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC PictureControlDesc;
        public IntPtr pInputFrame;
        public uint InputFrameSubresource;
        public uint CurrentFrameBitstreamMetadataSize;
    }
}
