// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(13096,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_AUTO_BREADCRUMB_NODE
    {
        public IntPtr pCommandListDebugNameA;
        public IntPtr pCommandListDebugNameW;
        public IntPtr pCommandQueueDebugNameA;
        public IntPtr pCommandQueueDebugNameW;
        public IntPtr pCommandList;
        public IntPtr pCommandQueue;
        public uint BreadcrumbCount;
        public IntPtr pLastBreadcrumbValue;
        public IntPtr pCommandHistory;
        public IntPtr pNext;
    }
}
