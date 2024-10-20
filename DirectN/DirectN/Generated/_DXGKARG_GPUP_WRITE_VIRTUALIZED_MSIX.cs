// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_GPUP_WRITE_VIRTUALIZED_MSIX
    {
        public uint vfIndex;
        public short InterruptTableIndex;
        public _DXGK_INTERRUPT_TABLE_ENTRY WriteValue;
    }
}
