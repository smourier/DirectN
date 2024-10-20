// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_DISPATCH_GRAPH_0084 = System.IntPtr;
using PFND3D12DDI_GET_PROGRAM_IDENTIFIER_0084 = System.IntPtr;
using PFND3D12DDI_GET_WORK_GRAPH_MEMORY_REQUIREMENTS_0084 = System.IntPtr;
using PFND3D12DDI_SET_PROGRAM_0084 = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_STATE_OBJECTS_EXPERIMENT_FUNCS_0084
    {
        public IntPtr pfnGetProgramIdentifier;
        public IntPtr pfnGetWorkGraphMemoryRequirements;
        public IntPtr pfnSetProgram;
        public IntPtr pfnDispatchGraph;
    }
}
