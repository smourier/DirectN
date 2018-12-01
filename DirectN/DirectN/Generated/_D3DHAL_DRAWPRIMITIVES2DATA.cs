// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(1628,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_DRAWPRIMITIVES2DATA
    {
        public IntPtr dwhContext;
        public uint dwFlags;
        public uint dwVertexType;
        public IntPtr lpDDCommands;
        public uint dwCommandOffset;
        public uint dwCommandLength;
        public _D3DHAL_DRAWPRIMITIVES2DATA__union_0 __union_6;
        public uint dwVertexOffset;
        public uint dwVertexLength;
        public uint dwReqVertexBufSize;
        public uint dwReqCommandBufSize;
        public IntPtr lpdwRStates;
        public _D3DHAL_DRAWPRIMITIVES2DATA__union_1 __union_12;
        public uint dwErrorOffset;
    }
}
