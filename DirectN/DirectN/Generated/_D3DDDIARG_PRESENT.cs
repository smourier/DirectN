﻿// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_PRESENT
    {
        public IntPtr hSrcResource;
        public uint SrcSubResourceIndex;
        public IntPtr hDstResource;
        public uint DstSubResourceIndex;
        public _D3DDDI_PRESENTFLAGS Flags;
        public D3DDDI_FLIPINTERVAL_TYPE FlipInterval;
    }
}
