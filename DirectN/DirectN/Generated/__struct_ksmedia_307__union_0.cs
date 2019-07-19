// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(910,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_ksmedia_307__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort wValidBitsPerSample { get => InteropRuntime.GetUInt16(__bits, 0, 16); set => InteropRuntime.SetUInt16(value, __bits, 0, 16); }
        public ushort wSamplesPerBlock { get => InteropRuntime.GetUInt16(__bits, 0, 16); set => InteropRuntime.SetUInt16(value, __bits, 0, 16); }
        public ushort wReserved { get => InteropRuntime.GetUInt16(__bits, 0, 16); set => InteropRuntime.SetUInt16(value, __bits, 0, 16); }
    }
}
