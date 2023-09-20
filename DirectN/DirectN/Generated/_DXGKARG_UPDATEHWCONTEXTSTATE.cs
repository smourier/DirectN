// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_UPDATEHWCONTEXTSTATE
    {
        public IntPtr hHwContext;
        public ulong ContextSwitchFence;
        public uint Priority;
        public _DXGK_UPDATEHWCONTEXTSTATE_FLAGS Flags;
    }
}
