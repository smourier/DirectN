// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_NODE_OUTPUT_OVERRIDES
    {
        public uint OutputIndex;
        public IntPtr pNewName;
        public IntPtr pAllowSparseNodes;
        public IntPtr pMaxRecords;
        public IntPtr pMaxRecordsSharedWithOutputIndex;
    }
}
