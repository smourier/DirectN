// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3d9types.h(1840,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DRASTER_STATUS
    {
        public bool InVBlank;
        public uint ScanLine;
    }
}
