// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(205,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PTE__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong Valid { get => InteropRuntime.GetUInt64(__bits, 0, 1); set => InteropRuntime.SetUInt64(value, __bits, 0, 1); }
        public ulong Zero { get => InteropRuntime.GetUInt64(__bits, 1, 1); set => InteropRuntime.SetUInt64(value, __bits, 1, 1); }
        public ulong CacheCoherent { get => InteropRuntime.GetUInt64(__bits, 2, 1); set => InteropRuntime.SetUInt64(value, __bits, 2, 1); }
        public ulong ReadOnly { get => InteropRuntime.GetUInt64(__bits, 3, 1); set => InteropRuntime.SetUInt64(value, __bits, 3, 1); }
        public ulong NoExecute { get => InteropRuntime.GetUInt64(__bits, 4, 1); set => InteropRuntime.SetUInt64(value, __bits, 4, 1); }
        public ulong Segment { get => InteropRuntime.GetUInt64(__bits, 5, 5); set => InteropRuntime.SetUInt64(value, __bits, 5, 5); }
        public ulong LargePage { get => InteropRuntime.GetUInt64(__bits, 10, 1); set => InteropRuntime.SetUInt64(value, __bits, 10, 1); }
        public ulong PhysicalAdapterIndex { get => InteropRuntime.GetUInt64(__bits, 11, 6); set => InteropRuntime.SetUInt64(value, __bits, 11, 6); }
        public ulong PageTablePageSize { get => InteropRuntime.GetUInt64(__bits, 17, 2); set => InteropRuntime.SetUInt64(value, __bits, 17, 2); }
        public ulong SystemReserved0 { get => InteropRuntime.GetUInt64(__bits, 19, 1); set => InteropRuntime.SetUInt64(value, __bits, 19, 1); }
        public ulong Reserved { get => InteropRuntime.GetUInt64(__bits, 20, 44); set => InteropRuntime.SetUInt64(value, __bits, 20, 44); }
    }
}
