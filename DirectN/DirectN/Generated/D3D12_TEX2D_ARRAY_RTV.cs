﻿// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_TEX2D_ARRAY_RTV
    {
        public uint MipSlice;
        public uint FirstArraySlice;
        public uint ArraySize;
        public uint PlaneSlice;
    }
}
