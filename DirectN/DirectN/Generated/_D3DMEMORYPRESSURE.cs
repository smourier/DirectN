// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3d9types.h(1981,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DMEMORYPRESSURE
    {
        public ulong BytesEvictedFromProcess;
        public ulong SizeOfInefficientAllocation;
        public uint LevelOfEfficiency;
    }
}
