// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SET_WORK_GRAPH_DESC_0084
    {
        public D3D12DDI_PROGRAM_IDENTIFIER_0108 ProgramIdentifier;
        public D3D12DDI_SET_WORK_GRAPH_FLAGS_0084 Flags;
        public D3D12DDI_GPU_VIRTUAL_ADDRESS_RANGE BackingMemory;
        public D3D12DDI_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE NodeLocalRootArgumentsTable;
    }
}
