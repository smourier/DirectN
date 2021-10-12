// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(2633,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GET_GPUMMU_CAPS
    {
        public uint PhysicalAdapterIndex;
        public _DXGK_ESCAPE_GPUMMUCAPS GpuMmuCaps;
    }
}
