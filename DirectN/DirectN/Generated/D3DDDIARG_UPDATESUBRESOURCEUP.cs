// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(2845,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDIARG_UPDATESUBRESOURCEUP
    {
        public IntPtr hResource;
        public uint SubResourceIndex;
        public _D3DDDIBOX DstBox;
        public IntPtr pSysMemUP;
        public uint RowPitch;
        public uint DepthPitch;
        public D3DDDIARG_COPYFLAGS Flags;
    }
}
