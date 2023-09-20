// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_QUERYAUTHENICATEDCHANNEL
    {
        public uint InputSize;
        public IntPtr pInputData;
        public uint OutputSize;
        public IntPtr pOutputData;
    }
}
