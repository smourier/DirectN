﻿// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDITRIPATCH_INFO
    {
        public uint StartVertexOffset;
        public uint NumVertices;
        public _D3DDDIBASISTYPE Basis;
        public _D3DDDIDEGREETYPE Degree;
    }
}
