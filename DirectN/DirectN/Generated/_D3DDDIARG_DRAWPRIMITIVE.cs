// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(316,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_DRAWPRIMITIVE
    {
        public _D3DPRIMITIVETYPE PrimitiveType;
        public uint VStart;
        public uint PrimitiveCount;
    }
}
