// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1852,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERY_GPUMMU_CAPS
    {
        public uint PhysicalAdapterIndex;
        public _D3DKMT_GPUMMU_CAPS Caps;
    }
}
