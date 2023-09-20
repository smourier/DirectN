// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _D3DKMT_DISPLAY_CAPS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong PreferPhysicallyContiguous { get => InteropRuntime.GetUInt64(__bits, 0, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 1); } }
        public ulong Reserved { get => InteropRuntime.GetUInt64(__bits, 1, 63); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 1, 63); } }
    }
}
