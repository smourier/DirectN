// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(465,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_CONTEXTCREATEDATA__union_3
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public uint dwPID => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public IntPtr dwrstates => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
    }
}
