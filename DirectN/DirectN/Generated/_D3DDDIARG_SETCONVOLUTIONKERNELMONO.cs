// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_SETCONVOLUTIONKERNELMONO
    {
        public uint Width;
        public uint Height;
        public IntPtr pKernelRow;
        public IntPtr pKernelCol;
    }
}
