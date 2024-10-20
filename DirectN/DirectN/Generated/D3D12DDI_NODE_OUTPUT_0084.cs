// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_NODE_OUTPUT_0084
    {
        public D3D12DDI_NODE_ID_0108 FinalName;
        public uint OutputIndex;
        public D3D12DDI_NODE_IO_KIND_0108 NodeIOKind;
        public uint NodeIOFlags;
        public uint RecordSizeInBytes;
        public bool bAllowSparseNodes;
        public IntPtr pRecordDispatchGrid;
        public IntPtr pMaxRecords;
        public IntPtr pMaxRecordsSharedWithOutputIndex;
        public uint ArraySize;
        public IntPtr ppNodeIndices;
    }
}
