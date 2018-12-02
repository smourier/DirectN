// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1451,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDI_RESERVEGPUVIRTUALADDRESS__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public _D3DDDIGPUVIRTUALADDRESS_RESERVATION_TYPE ReservationType => InteropRuntime.Get<_D3DDDIGPUVIRTUALADDRESS_RESERVATION_TYPE>(__bits, 0, 32);
        public uint Reserved0 => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
