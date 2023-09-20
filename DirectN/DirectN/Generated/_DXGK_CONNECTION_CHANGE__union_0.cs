// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_CONNECTION_CHANGE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_CONNECTION_CHANGE__union_0__struct_0 MonitorConnect { get => InteropRuntime.Get<_DXGK_CONNECTION_CHANGE__union_0__struct_0>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_DXGK_CONNECTION_CHANGE__union_0__struct_0>(value, __bits, 0, 64); } }
        public _DXGK_CONNECTION_CHANGE__union_0__struct_1 TargetConnect { get => InteropRuntime.Get<_DXGK_CONNECTION_CHANGE__union_0__struct_1>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_DXGK_CONNECTION_CHANGE__union_0__struct_1>(value, __bits, 0, 64); } }
        public _DXGK_CONNECTION_CHANGE__union_0__struct_2 TargetJoin { get => InteropRuntime.Get<_DXGK_CONNECTION_CHANGE__union_0__struct_2>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_DXGK_CONNECTION_CHANGE__union_0__struct_2>(value, __bits, 0, 64); } }
    }
}
