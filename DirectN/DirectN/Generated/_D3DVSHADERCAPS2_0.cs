// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3d9caps.h(29,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DVSHADERCAPS2_0
    {
        public uint Caps;
        public int DynamicFlowControlDepth;
        public int NumTemps;
        public int StaticFlowControlDepth;
    }
}
