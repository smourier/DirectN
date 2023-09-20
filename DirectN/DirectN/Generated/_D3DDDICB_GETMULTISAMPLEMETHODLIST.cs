// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_GETMULTISAMPLEMETHODLIST
    {
        public uint VidPnSourceId;
        public uint Width;
        public uint Height;
        public _D3DDDIFORMAT Format;
        public IntPtr pMethodList;
        public uint MethodCount;
    }
}
