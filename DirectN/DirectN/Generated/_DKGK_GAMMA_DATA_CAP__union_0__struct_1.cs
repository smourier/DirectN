// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(2525,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DKGK_GAMMA_DATA_CAP__union_0__struct_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint BitCountOfExponent { get => InteropRuntime.GetUInt32(__bits, 0, 6); set => InteropRuntime.SetUInt32(value, __bits, 0, 6); }
        public uint BitCountOfMantissa { get => InteropRuntime.GetUInt32(__bits, 6, 6); set => InteropRuntime.SetUInt32(value, __bits, 6, 6); }
    }
}
