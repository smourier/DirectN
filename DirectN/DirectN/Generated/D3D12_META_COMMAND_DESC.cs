﻿// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_META_COMMAND_DESC
    {
        public Guid Id;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        public D3D12_GRAPHICS_STATES InitializationDirtyState;
        public D3D12_GRAPHICS_STATES ExecutionDirtyState;
    }
}
