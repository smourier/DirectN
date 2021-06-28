// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(13302,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_AUTO_BREADCRUMB_NODE
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public byte pCommandListDebugNameA;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char pCommandListDebugNameW;
        [MarshalAs(UnmanagedType.LPStr)] 
        public byte pCommandQueueDebugNameA;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char pCommandQueueDebugNameW;
        public IntPtr pCommandList;
        public IntPtr pCommandQueue;
        public uint BreadcrumbCount;
        public IntPtr pLastBreadcrumbValue;
        public IntPtr pCommandHistory;
        public IntPtr pNext;
    }
}
