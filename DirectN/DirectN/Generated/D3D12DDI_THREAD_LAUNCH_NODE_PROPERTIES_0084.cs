// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_THREAD_LAUNCH_NODE_PROPERTIES_0084
    {
        public D3D12DDI_NODE_ID_0108 FinalName;
        public bool bProgramEntry;
        public D3D12DDI_NODE_IO_KIND_0108 InputNodeIOKind;
        public uint InputNodeIOFlags;
        public uint InputRecordSizeInBytes;
        public uint GroupSharedUsageInBytes;
        public uint MaxRecursionDepth;
        public IntPtr pLocalRootArgumentsTableIndex;
        public IntPtr pShareInputOfNodeIndex;
        public uint NumInputNodeIndices;
        public IntPtr pInputNodeIndices;
        public uint NumNodesSharingInputWithThisNode;
        public IntPtr pIndicesOfNodesSharingInputWithThisNode;
        public uint NumOutputs;
        public IntPtr pOutputs;
    }
}
