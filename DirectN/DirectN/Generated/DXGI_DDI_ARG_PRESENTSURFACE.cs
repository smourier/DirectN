// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxgiddi.h(500,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_ARG_PRESENTSURFACE
    {
        public ulong hSurface;
        public uint SubResourceIndex;
    }
}
