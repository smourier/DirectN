// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(861,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_CANCELFLIPS_PLANE
    {
        public ulong PresentIdCancelRequested;
        public ulong PresentIdCancelled;
        public uint LayerIndex;
    }
}
