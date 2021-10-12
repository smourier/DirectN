// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(13565,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_ENCODEFRAME_INPUT_STREAM_ARGUMENTS_0082_0
    {
        public D3D12DDI_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC_0082_0 SequenceControlDesc;
        public D3D12DDI_VIDEO_ENCODER_PICTURE_CONTROL_DESC_0082_0 PictureControlDesc;
        public D3D10DDI_HRESOURCE hDrvInputTexture2D;
        public uint InputFrameSubresource;
        public uint CurrentFrameBitstreamMetadataSize;
    }
}
