﻿// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDICB_SIGNALSYNCHRONIZATIONOBJECTFROMGPU
    {
        public IntPtr hContext;
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public D3DDDICB_SIGNALSYNCHRONIZATIONOBJECTFROMGPU__union_0 __union_3;
    }
}
