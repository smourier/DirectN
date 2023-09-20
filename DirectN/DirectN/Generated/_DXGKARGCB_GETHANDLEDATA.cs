// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_GETHANDLEDATA
    {
        public uint hObject;
        public _DXGK_HANDLE_TYPE Type;
        public _DXGKCB_GETHANDLEDATAFLAGS Flags;
    }
}
