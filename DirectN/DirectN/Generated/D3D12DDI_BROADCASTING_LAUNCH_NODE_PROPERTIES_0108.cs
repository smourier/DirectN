// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;
using D3D12DDI_NODE_0108 = DirectN._D3D12DDI_NODE_0108;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_BROADCASTING_LAUNCH_NODE_PROPERTIES_0108
    {
        public D3D12DDI_NODE_ID_0108 FinalName;
        public bool bProgramEntry;
        public D3D12DDI_NODE_IO_KIND_0108 InputNodeIOKind;
        public uint InputNodeIOFlags;
        public uint InputRecordSizeInBytes;
        public uint GroupSharedUsageInBytes;
        public uint MaxRecursionDepth;
        public IntPtr pLocalRootArgumentsTableIndex;
        public IntPtr pShareInputOfNode;
        public IntPtr pDispatchGrid;
        public IntPtr pMaxDispatchGrid;
        public IntPtr pRecordDispatchGrid;
        public IntPtr pInputNodes;
        public IntPtr pNodesSharingInputWithThisNode;
        public uint NumOutputs;
        public IntPtr pOutputs;
    }
}
