﻿// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_5
    {
        public uint hAdapter;
        public uint VidPnTargetId;
        public ulong Time;
        public IntPtr FenceValueCPUVirtualAddress;
        public ulong FenceValueGPUVirtualAddress;
        public uint EngineAffinity;
        public uint Padding;
    }
}
