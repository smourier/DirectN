// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(8194,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DSI2_PACKET__union_1__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint Data0 { get => InteropRuntime.GetUInt32(__bits, 0, 8); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt32(value, __bits, 0, 8); } }
        public uint Data1 { get => InteropRuntime.GetUInt32(__bits, 8, 8); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt32(value, __bits, 8, 8); } }
    }
}
