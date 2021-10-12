// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(7732,9)
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
