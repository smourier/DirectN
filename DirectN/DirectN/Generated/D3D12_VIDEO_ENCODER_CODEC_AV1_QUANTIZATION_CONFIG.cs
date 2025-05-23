﻿// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG
    {
        public ulong BaseQIndex;
        public long YDCDeltaQ;
        public long UDCDeltaQ;
        public long UACDeltaQ;
        public long VDCDeltaQ;
        public long VACDeltaQ;
        public ulong UsingQMatrix;
        public ulong QMY;
        public ulong QMU;
        public ulong QMV;
    }
}
