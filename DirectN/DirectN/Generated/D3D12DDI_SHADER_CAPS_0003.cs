﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SHADER_CAPS_0003
    {
        public D3D12DDI_SHADER_MIN_PRECISION MinPrecision;
        public bool Doubles;
        public bool ShaderSpecifiedStencilRef;
        public bool TypedUAVLoadAdditionalFormats;
        public bool ROVs;
    }
}
