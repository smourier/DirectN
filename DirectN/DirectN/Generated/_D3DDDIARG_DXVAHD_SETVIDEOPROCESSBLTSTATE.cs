﻿// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_DXVAHD_SETVIDEOPROCESSBLTSTATE
    {
        public IntPtr hVideoProcessor;
        public _DXVAHDDDI_BLT_STATE State;
        public uint DataSize;
        public IntPtr pData;
    }
}
