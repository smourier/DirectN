// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_POWER_RUNTIME_COMPONENT
    {
        public uint StateCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public _DXGK_POWER_RUNTIME_STATE[] States;
        public _DXGK_POWER_COMPONENT_MAPPING ComponentMapping;
        public _DXGK_POWER_COMPONENT_FLAGS Flags;
        public Guid ComponentGuid;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)] 
        public byte[] ComponentName;
        public uint ProviderCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public uint[] Providers;
    }
}
