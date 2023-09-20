// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SYNCHRONIZATIONOBJECTINFO2
    {
        public _D3DDDI_SYNCHRONIZATIONOBJECT_TYPE Type;
        public _D3DDDI_SYNCHRONIZATIONOBJECT_FLAGS Flags;
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0 __union_2;
        public uint SharedHandle;
    }
}
