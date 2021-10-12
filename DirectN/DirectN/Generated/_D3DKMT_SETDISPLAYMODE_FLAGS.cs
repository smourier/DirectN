// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(293,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SETDISPLAYMODE_FLAGS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte PreserveVidPn { get => InteropRuntime.GetByte(__bits, 0, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetByte(value, __bits, 0, 1); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 32, 31); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 32, 31); } }
    }
}
