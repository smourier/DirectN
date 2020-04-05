// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(8180,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DSI2_PACKET
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_DSI2_PACKET__union_0 __union_0 { get => InteropRuntime.Get<_DXGK_DSI2_PACKET__union_0>(__bits, 0, 8); set { if (__bits == null) __bits = new byte[20]; InteropRuntime.Set<_DXGK_DSI2_PACKET__union_0>(value, __bits, 0, 8); } }
        public _DXGK_DSI2_PACKET__union_1 __union_1 { get => InteropRuntime.Get<_DXGK_DSI2_PACKET__union_1>(__bits, 0, 16); set { if (__bits == null) __bits = new byte[20]; InteropRuntime.Set<_DXGK_DSI2_PACKET__union_1>(value, __bits, 0, 16); } }
        public uint EccFiller { get => InteropRuntime.GetUInt32(__bits, 64, 8); set { if (__bits == null) __bits = new byte[20]; InteropRuntime.SetUInt32(value, __bits, 64, 8); } }
        public byte[] Payload { get => InteropRuntime.GetArray<byte>(__bits, 96, 64); set { if (__bits == null) __bits = new byte[20]; InteropRuntime.SetArray<byte>(value, __bits, 96, 64); } }
    }
}
