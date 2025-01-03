﻿// generated from <Windows SDK Path>\um\d3d12video.h
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS
    {
        D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_NONE = 0x00000000,
        D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_DELTA_QP = 0x00000001,
        D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_FRAME_ANALYSIS = 0x00000002,
        D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_QP_RANGE = 0x00000004,
        D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_INITIAL_QP = 0x00000008,
        D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_MAX_FRAME_SIZE = 0x00000010,
        D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_VBV_SIZES = 0x00000020,
        D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_EXTENSION1_SUPPORT = 0x00000040,
        D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_QUALITY_VS_SPEED = 0x00000080,
    }
}
