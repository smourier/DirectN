// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_POWER_P_COMPONENT
    {
        public uint StateCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public _DXGK_POWER_P_STATE[] States;
        public _DXGK_POWER_COMPONENT_P_FLAGS Flags;
    }
}
