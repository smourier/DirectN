// generated from <Windows SDK Path>\shared\dxgi1_2.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_SWAP_CHAIN_DESC1
    {
        public uint Width;
        public uint Height;
        public DXGI_FORMAT Format;
        public bool Stereo;
        public DXGI_SAMPLE_DESC SampleDesc;
        public uint BufferUsage;
        public uint BufferCount;
        public DXGI_SCALING Scaling;
        public DXGI_SWAP_EFFECT SwapEffect;
        public DXGI_ALPHA_MODE AlphaMode;
        public uint Flags;
    }
}
