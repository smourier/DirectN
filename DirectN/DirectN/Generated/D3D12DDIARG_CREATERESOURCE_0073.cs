﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATERESOURCE_0073
    {
        public D3D12DDIARG_BUFFER_PLACEMENT ReuseBufferGPUVA;
        public D3D12DDI_RESOURCE_TYPE ResourceType;
        public ulong Width;
        public uint Height;
        public ushort DepthOrArraySize;
        public ushort MipLevels;
        public DXGI_FORMAT Format;
        public DXGI_SAMPLE_DESC SampleDesc;
        public D3D12DDI_TEXTURE_LAYOUT Layout;
        public D3D12DDI_RESOURCE_FLAGS_0003 Flags;
        public D3D12DDI_RESOURCE_STATES InitialResourceState;
        public IntPtr pRowMajorLayout;
        public D3D12DDI_SAMPLER_FEEDBACK_DESC_0073 SamplerFeedbackDesc;
    }
}
