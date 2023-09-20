// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_META_COMMAND_PARAMETER_DESC
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        public D3D12_META_COMMAND_PARAMETER_TYPE Type;
        public D3D12_META_COMMAND_PARAMETER_FLAGS Flags;
        public D3D12_RESOURCE_STATES RequiredResourceState;
        public uint StructureOffset;
    }
}
