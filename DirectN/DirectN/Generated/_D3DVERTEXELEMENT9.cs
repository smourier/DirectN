// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3d9types.h(778,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DVERTEXELEMENT9
    {
        public ushort Stream;
        public ushort Offset;
        public byte Type;
        public byte Method;
        public byte Usage;
        public byte UsageIndex;
    }
}
