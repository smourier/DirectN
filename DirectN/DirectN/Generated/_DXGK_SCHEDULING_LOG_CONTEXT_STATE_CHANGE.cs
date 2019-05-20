// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(4346,9)
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
