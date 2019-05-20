// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dukmdt.h(169,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKVGPU_ESCAPE_WRITE_PCI_CONFIG
    {
        public _DXGKVGPU_ESCAPE_HEAD Header;
        public uint Offset;
        public uint Size;
    }
}
