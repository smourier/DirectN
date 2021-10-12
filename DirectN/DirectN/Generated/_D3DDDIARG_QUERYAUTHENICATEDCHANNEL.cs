// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(1904,9)
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
