// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(7893,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_CONNECTION_CHANGE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong ConnectionChangeId { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
        public uint TargetId { get => InteropRuntime.GetUInt32(__bits, 64, 24); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.SetUInt32(value, __bits, 64, 24); } }
        public _DXGK_CONNECTION_STATUS ConnectionStatus { get => InteropRuntime.Get<_DXGK_CONNECTION_STATUS>(__bits, 88, 4); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<_DXGK_CONNECTION_STATUS>(value, __bits, 88, 4); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 92, 4); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.SetUInt32(value, __bits, 92, 4); } }
        public _DXGK_CONNECTION_CHANGE__union_0 __union_4 { get => InteropRuntime.Get<_DXGK_CONNECTION_CHANGE__union_0>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<_DXGK_CONNECTION_CHANGE__union_0>(value, __bits, 0, 64); } }
    }
}
