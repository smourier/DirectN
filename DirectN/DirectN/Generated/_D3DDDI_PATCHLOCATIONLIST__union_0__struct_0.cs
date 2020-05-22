// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dukmdt.h(430,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_PATCHLOCATIONLIST__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint SlotId { get => InteropRuntime.GetUInt32(__bits, 0, 24); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 24); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 24, 8); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 24, 8); } }
    }
}
