﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RENDER_TARGET_BLEND_DESC
    {
        public bool BlendEnable;
        public bool LogicOpEnable;
        public D3D12DDI_BLEND SrcBlend;
        public D3D12DDI_BLEND DestBlend;
        public D3D12DDI_BLEND_OP BlendOp;
        public D3D12DDI_BLEND SrcBlendAlpha;
        public D3D12DDI_BLEND DestBlendAlpha;
        public D3D12DDI_BLEND_OP BlendOpAlpha;
        public D3D12DDI_LOGIC_OP LogicOp;
        public byte RenderTargetWriteMask;
    }
}
