// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SCHEDULING_LOG_CONTEXT_STATE_CHANGE
    {
        public IntPtr hKmdContext;
        public _DXGK_SCHEDULING_LOG_CONTEXT_STATE newContextState;
    }
}
