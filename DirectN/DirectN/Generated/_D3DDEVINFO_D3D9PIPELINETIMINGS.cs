// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDEVINFO_D3D9PIPELINETIMINGS
    {
        public float VertexProcessingTimePercent;
        public float PixelProcessingTimePercent;
        public float OtherGPUProcessingTimePercent;
        public float GPUIdleTimePercent;
    }
}
