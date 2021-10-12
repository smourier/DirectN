// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dxgi.h(293,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_SWAP_CHAIN_DESC
    {
        public DXGI_MODE_DESC BufferDesc;
        public DXGI_SAMPLE_DESC SampleDesc;
        public uint BufferUsage;
        public uint BufferCount;
        public IntPtr OutputWindow;
        public bool Windowed;
        public DXGI_SWAP_EFFECT SwapEffect;
        public uint Flags;
    }
}
