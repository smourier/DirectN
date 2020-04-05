// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(81,5)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ALLOCATIONLIST__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public PHYSICAL_ADDRESS PhysicalAddress { get => InteropRuntime.Get<PHYSICAL_ADDRESS>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<PHYSICAL_ADDRESS>(value, __bits, 0, 64); } }
        public ulong VirtualAddress { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
    }
}
