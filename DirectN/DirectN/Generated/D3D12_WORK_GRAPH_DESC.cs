// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_WORK_GRAPH_DESC
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string ProgramName;
        public D3D12_WORK_GRAPH_FLAGS Flags;
        public uint NumEntrypoints;
        public IntPtr pEntrypoints;
        public uint NumExplicitlyDefinedNodes;
        public IntPtr pExplicitlyDefinedNodes;
    }
}
