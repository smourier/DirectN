// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dnthal.h(522,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_DP2COMMAND__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort wPrimitiveCount { get => InteropRuntime.GetUInt16(__bits, 0, 16); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 16); } }
        public ushort wStateCount { get => InteropRuntime.GetUInt16(__bits, 0, 16); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 16); } }
    }
}
