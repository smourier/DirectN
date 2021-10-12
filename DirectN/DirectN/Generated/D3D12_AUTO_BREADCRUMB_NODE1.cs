// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(14211,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_AUTO_BREADCRUMB_NODE1
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public byte pCommandListDebugNameA;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pCommandListDebugNameW;
        [MarshalAs(UnmanagedType.LPStr)] 
        public byte pCommandQueueDebugNameA;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pCommandQueueDebugNameW;
        public IntPtr pCommandList;
        public IntPtr pCommandQueue;
        public uint BreadcrumbCount;
        public IntPtr pLastBreadcrumbValue;
        public IntPtr pCommandHistory;
        public IntPtr pNext;
        public uint BreadcrumbContextsCount;
        public IntPtr pBreadcrumbContexts;
    }
}
