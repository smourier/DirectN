using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_SWAP_CHAIN_DESC
    {
        public DXGI_MODE_DESC BufferDesc;
        public DXGI_SAMPLE_DESC SampleDesc;
        public DXGI_USAGE BufferUsage;
        public int BufferCount;
        public IntPtr OutputWindow;
        public bool Windowed;
        public DXGI_SWAP_EFFECT SwapEffect;
        public DXGI_SWAP_CHAIN_FLAG Flags;
    }
}
