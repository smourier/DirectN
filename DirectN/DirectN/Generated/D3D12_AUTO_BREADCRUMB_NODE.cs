// generated from <Windows SDK Path>\um\d3d12.h
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
    }
}
