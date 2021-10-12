// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(8547,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SET_TIMING_PATH_INFO__union_1__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_PATH_UPDATE VidPnPathUpdates { get => InteropRuntime.Get<_DXGK_PATH_UPDATE>(__bits, 0, 2); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_PATH_UPDATE>(value, __bits, 0, 2); } }
        public uint Active { get => InteropRuntime.GetUInt32(__bits, 2, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 2, 1); } }
        public uint IgnoreConnectivity { get => InteropRuntime.GetUInt32(__bits, 3, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 3, 1); } }
        public uint PreserveInherited { get => InteropRuntime.GetUInt32(__bits, 4, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 4, 1); } }
        public uint SyncLockGroup { get => InteropRuntime.GetUInt32(__bits, 5, 3); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 5, 3); } }
        public _DXGK_SYNC_LOCK_STYLE SyncLockStyle { get => InteropRuntime.Get<_DXGK_SYNC_LOCK_STYLE>(__bits, 8, 4); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_SYNC_LOCK_STYLE>(value, __bits, 8, 4); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 12, 20); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 12, 20); } }
    }
}
