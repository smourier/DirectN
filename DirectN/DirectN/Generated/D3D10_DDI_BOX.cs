// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(1248,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_DDI_BOX
    {
        public int left;
        public int top;
        public int front;
        public int right;
        public int bottom;
        public int back;
    }
}
