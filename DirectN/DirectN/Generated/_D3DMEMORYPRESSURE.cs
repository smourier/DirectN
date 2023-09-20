// generated from <Windows SDK Path>\shared\d3d9types.h
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
