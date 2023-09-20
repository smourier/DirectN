// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_FUNCTION_SUMMARY_NODE_0054
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string ExportNameUnmangled;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string ExportNameMangled;
        public uint NumAssociatedSubobjects;
        public IntPtr ppAssociatedSubobjects;
        public D3D12DDI_EXPORT_SUMMARY_FLAGS Flags;
    }
}
