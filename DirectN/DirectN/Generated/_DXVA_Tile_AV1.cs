// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1745,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Tile_AV1
    {
        public uint DataOffset;
        public uint DataSize;
        public ushort row;
        public ushort column;
        public ushort Reserved16Bits;
        public byte anchor_frame;
        public byte Reserved8Bits;
    }
}
