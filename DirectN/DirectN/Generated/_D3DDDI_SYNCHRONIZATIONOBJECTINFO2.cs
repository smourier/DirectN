// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1636,9)
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
