// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PHYSICALADAPTERCAPS
    {
        public ushort NumExecutionNodes;
        public ushort PagingNodeIndex;
        public IntPtr DxgkPhysicalAdapterHandle;
        public _DXGK_PHYSICALADAPTERFLAGS Flags;
        public uint VPRPagingNode;
        public uint VirtualCopyNodeIndex;
    }
}
