// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3d9types.h(1981,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DMEMORYPRESSURE_32
    {
        public ulong BytesEvictedFromProcess;
        public ulong SizeOfInefficientAllocation;
        public uint LevelOfEfficiency;
    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DMEMORYPRESSURE_64
    {
        public ulong BytesEvictedFromProcess;
        public ulong SizeOfInefficientAllocation;
        public uint LevelOfEfficiency;
    }
}
