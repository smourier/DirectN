// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(1080,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_DP2RENDERSTATE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public float dvState => InteropRuntime.GetSingle(__bits, 0, 32);
        public uint dwState => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
