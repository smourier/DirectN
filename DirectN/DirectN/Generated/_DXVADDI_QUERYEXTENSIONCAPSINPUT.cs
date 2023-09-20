// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVADDI_QUERYEXTENSIONCAPSINPUT
    {
        public IntPtr pGuid;
        public uint CapType;
        public IntPtr pPrivate;
    }
}
