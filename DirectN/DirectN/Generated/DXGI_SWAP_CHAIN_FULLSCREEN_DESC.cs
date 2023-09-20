// generated from <Windows SDK Path>\shared\dxgi1_2.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_SWAP_CHAIN_FULLSCREEN_DESC
    {
        public DXGI_RATIONAL RefreshRate;
        public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;
        public DXGI_MODE_SCALING Scaling;
        public bool Windowed;
    }
}
