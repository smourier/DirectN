// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dcaps.h(529,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DFINDDEVICESEARCH
    {
        public uint dwSize;
        public uint dwFlags;
        public bool bHardware;
        public uint dcmColorModel;
        public Guid guid;
        public uint dwCaps;
        public _D3DPrimCaps dpcPrimCaps;
    }
}
