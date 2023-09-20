// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDI_VIDEO_CAPABILITY_RECOMMEND_DECODER_DOWNSAMPLING
    {
        public IntPtr pInputDesc;
        public D3DDDI_COLOR_SPACE_TYPE InputColorSpace;
        public IntPtr pInputConfig;
        public IntPtr pFrameRate;
        public IntPtr pOutputDesc;
        public D3DDDI_COLOR_SPACE_TYPE OutputColorSpace;
    }
}
