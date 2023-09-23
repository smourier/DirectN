// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS13
    {
        public bool UnrestrictedBufferTextureCopyPitchSupported;
        public bool UnrestrictedVertexElementAlignmentSupported;
        public bool InvertedViewportHeightFlipsYSupported;
        public bool InvertedViewportDepthFlipsZSupported;
        public bool TextureCopyBetweenDimensionsSupported;
        public bool AlphaBlendFactorSupported;
    }
}
