// generated from <Windows SDK Path>\um\d3d12.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_SET_WORK_GRAPH_DESC
    {
        public D3D12_PROGRAM_IDENTIFIER ProgramIdentifier;
        public D3D12_SET_WORK_GRAPH_FLAGS Flags;
        public D3D12_GPU_VIRTUAL_ADDRESS_RANGE BackingMemory;
        public D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE NodeLocalRootArgumentsTable;
    }
}
