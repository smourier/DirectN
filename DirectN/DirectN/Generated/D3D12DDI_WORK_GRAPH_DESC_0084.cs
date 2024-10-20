// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_WORK_GRAPH_DESC_0084
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string ProgramName;
        public uint NumNodes;
        public IntPtr ppNodes;
        public uint NumEntrypoints;
        public IntPtr pEntrypointNodeIndices;
    }
}
