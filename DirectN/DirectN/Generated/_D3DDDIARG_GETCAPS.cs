// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(2146,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_GETCAPS
    {
        public _D3DDDICAPS_TYPE Type;
        public IntPtr pInfo;
        public IntPtr pData;
        public uint DataSize;
    }
}
