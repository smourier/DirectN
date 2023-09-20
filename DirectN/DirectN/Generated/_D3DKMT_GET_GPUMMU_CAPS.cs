// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
