﻿// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_KERNELOVERLAYINFO
    {
        public uint hAllocation;
        public _D3DDDIRECT DstRect;
        public _D3DDDIRECT SrcRect;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}
