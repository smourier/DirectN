﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_DECODE_CONVERSION_SUPPORT_DATA_0032
    {
        public uint NodeIndex;
        public D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020 Configuration;
        public D3D12DDI_VIDEO_SAMPLE_DESCRIPTION_0020 DecodeSample;
        public D3D12DDI_VIDEO_FORMAT_DESCRIPTION_0020 OutputFormat;
        public DXGI_RATIONAL FrameRate;
        public uint BitRate;
        public D3D12DDI_VIDEO_DECODE_CONVERSION_SUPPORT_FLAGS_0020 SupportFlags;
        public D3D12DDI_VIDEO_SCALE_SUPPORT_0032 ScaleSupport;
    }
}
