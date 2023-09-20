// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_META_COMMAND_PARAMETER_DESC
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        public D3D12DDI_META_COMMAND_PARAMETER_TYPE Type;
        public D3D12DDI_META_COMMAND_PARAMETER_FLAGS Flags;
        public D3D12DDI_RESOURCE_STATES RequiredResourceState;
    }
}
