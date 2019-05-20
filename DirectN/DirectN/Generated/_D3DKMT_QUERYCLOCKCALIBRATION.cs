// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmdt.h(2109,9)
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
