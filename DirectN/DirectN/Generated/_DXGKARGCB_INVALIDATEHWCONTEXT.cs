// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_INVALIDATEHWCONTEXT
    {
        public IntPtr hAdapter;
        public IntPtr hHwContext;
        public _DXGK_INVALIDATEHWCONTEXTFLAGS Flags;
    }
}
