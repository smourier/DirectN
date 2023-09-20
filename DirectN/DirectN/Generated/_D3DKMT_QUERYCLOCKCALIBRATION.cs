// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _D3DKMT_QUERYCLOCKCALIBRATION
    {
        public uint hAdapter;
        public uint NodeOrdinal;
        public uint PhysicalAdapterIndex;
        public _DXGK_GPUCLOCKDATA ClockData;
    }
}
