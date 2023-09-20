// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_DISCARD
    {
        public IntPtr hResource;
        public uint FirstSubResource;
        public uint NumSubResources;
        public IntPtr pRects;
        public uint NumRects;
    }
}
