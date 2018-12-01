// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10.h(800,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_BOX
    {
        public uint left;
        public uint top;
        public uint front;
        public uint right;
        public uint bottom;
        public uint back;
    }
}
