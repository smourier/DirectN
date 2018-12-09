// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(221,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PTE__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong PageAddress { get => InteropRuntime.GetUInt64(__bits, 0, 64); set => InteropRuntime.SetUInt64(value, __bits, 0, 64); }
        public ulong PageTableAddress { get => InteropRuntime.GetUInt64(__bits, 0, 64); set => InteropRuntime.SetUInt64(value, __bits, 0, 64); }
    }
}
