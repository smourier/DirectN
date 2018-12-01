// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9types.h(1767,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DBOX
    {
        public uint Left;
        public uint Top;
        public uint Right;
        public uint Bottom;
        public uint Front;
        public uint Back;
    }
}
