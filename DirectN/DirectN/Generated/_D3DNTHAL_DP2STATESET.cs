// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dnthal.h(786,9)
using System;
using System.Runtime.InteropServices;
using D3DSTATEBLOCKTYPE = DirectN._D3DSTATEBLOCKTYPE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_DP2STATESET
    {
        public uint dwOperation;
        public uint dwParam;
        public D3DSTATEBLOCKTYPE sbType;
    }
}
