// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4826,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SCHEDULING_LOG_ENTRY__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_SCHEDULING_LOG_CONTEXT_STATE_CHANGE ContextStateChange { get => InteropRuntime.Get<_DXGK_SCHEDULING_LOG_CONTEXT_STATE_CHANGE>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_DXGK_SCHEDULING_LOG_CONTEXT_STATE_CHANGE>(value, __bits, 0, 96); } }
        public ulong[] ReservedOperationData { get => InteropRuntime.GetArray<ulong>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetArray<ulong>(value, __bits, 0, 128); } }
    }
}
