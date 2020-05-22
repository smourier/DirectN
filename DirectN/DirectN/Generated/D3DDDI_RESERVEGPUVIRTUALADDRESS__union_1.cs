// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dukmdt.h(1494,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDI_RESERVEGPUVIRTUALADDRESS__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDIGPUVIRTUALADDRESS_RESERVATION_TYPE ReservationType { get => InteropRuntime.Get<_D3DDDIGPUVIRTUALADDRESS_RESERVATION_TYPE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DDDIGPUVIRTUALADDRESS_RESERVATION_TYPE>(value, __bits, 0, 32); } }
        public uint Reserved0 { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
