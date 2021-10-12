// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dukmdt.h(182,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKVGPU_ESCAPE_READ_PCI_CONFIG
    {
        public _DXGKVGPU_ESCAPE_HEAD Header;
        public uint Offset;
        public uint Size;
    }
}
