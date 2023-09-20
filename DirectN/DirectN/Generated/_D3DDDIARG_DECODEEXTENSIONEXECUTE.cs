// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_DECODEEXTENSIONEXECUTE
    {
        public IntPtr hDecode;
        public uint Function;
        public IntPtr pPrivateInput;
        public IntPtr pPrivateOutput;
        public uint NumBuffers;
        public IntPtr pBuffers;
    }
}
