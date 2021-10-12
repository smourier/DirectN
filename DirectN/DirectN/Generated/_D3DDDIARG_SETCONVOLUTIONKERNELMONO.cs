// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(716,9)
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
