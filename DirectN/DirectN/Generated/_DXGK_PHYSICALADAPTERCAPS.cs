// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(2111,9)
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
