// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(1759,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PAGETABLEUPDATEADDRESS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr CpuVirtual { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set => InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); }
        public _D3DGPU_PHYSICAL_ADDRESS GpuPhysical { get => InteropRuntime.Get<_D3DGPU_PHYSICAL_ADDRESS>(__bits, 0, 128); set => InteropRuntime.Set<_D3DGPU_PHYSICAL_ADDRESS>(value, __bits, 0, 128); }
        public ulong GpuVirtual { get => InteropRuntime.GetUInt64(__bits, 0, 64); set => InteropRuntime.SetUInt64(value, __bits, 0, 64); }
    }
}
