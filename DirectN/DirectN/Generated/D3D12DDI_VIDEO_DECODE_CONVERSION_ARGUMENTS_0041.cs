﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041
    {
        public bool Enable;
        public D3D10DDI_HRESOURCE hDrvReferenceTexture2D;
        public uint ReferenceSubresource;
        public DXGI_COLOR_SPACE_TYPE OutputColorSpace;
        public DXGI_COLOR_SPACE_TYPE DecodeColorSpace;
        public uint OutputWidth;
        public uint OutputHeight;
    }
}
