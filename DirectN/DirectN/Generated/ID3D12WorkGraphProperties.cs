// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("065acf71-f863-4b89-82f4-02e4d5886757"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12WorkGraphProperties
    {
        [PreserveSig]
        uint GetNumWorkGraphs();
        
        [PreserveSig]
        string GetProgramName(uint WorkGraphIndex);
        
        [PreserveSig]
        uint GetWorkGraphIndex([MarshalAs(UnmanagedType.LPWStr)] string pProgramName);
        
        [PreserveSig]
        uint GetNumNodes(uint WorkGraphIndex);
        
        [PreserveSig]
        D3D12_NODE_ID GetNodeID(uint WorkGraphIndex, uint NodeIndex);
        
        [PreserveSig]
        uint GetNodeIndex(uint WorkGraphIndex, D3D12_NODE_ID NodeID);
        
        [PreserveSig]
        uint GetNodeLocalRootArgumentsTableIndex(uint WorkGraphIndex, uint NodeIndex);
        
        [PreserveSig]
        uint GetNumEntrypoints(uint WorkGraphIndex);
        
        [PreserveSig]
        D3D12_NODE_ID GetEntrypointID(uint WorkGraphIndex, uint EntrypointIndex);
        
        [PreserveSig]
        uint GetEntrypointIndex(uint WorkGraphIndex, D3D12_NODE_ID NodeID);
        
        [PreserveSig]
        uint GetEntrypointRecordSizeInBytes(uint WorkGraphIndex, uint EntrypointIndex);
        
        [PreserveSig]
        void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, /* _Out_ */ out D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS pWorkGraphMemoryRequirements);
    }
}
