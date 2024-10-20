// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_INTERRUPT_TABLE_ENTRY
    {
        public ulong MessageAddress;
        public uint MessageData;
        public uint VectorControl;
    }
}
