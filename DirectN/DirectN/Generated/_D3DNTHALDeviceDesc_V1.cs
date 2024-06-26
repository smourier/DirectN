﻿// generated from <Windows SDK Path>\um\d3dnthal.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHALDeviceDesc_V1
    {
        public uint dwSize;
        public uint dwFlags;
        public uint dcmColorModel;
        public uint dwDevCaps;
        public _D3DTRANSFORMCAPS dtcTransformCaps;
        public bool bClipping;
        public _D3DLIGHTINGCAPS dlcLightingCaps;
        public _D3DPrimCaps dpcLineCaps;
        public _D3DPrimCaps dpcTriCaps;
        public uint dwDeviceRenderBitDepth;
        public uint dwDeviceZBufferBitDepth;
        public uint dwMaxBufferSize;
        public uint dwMaxVertexCount;
    }
}
