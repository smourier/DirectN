// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1630,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_BOX
    {
        public int Left;
        public int Top;
        public int Front;
        public int Right;
        public int Bottom;
        public int Back;
    }
}
