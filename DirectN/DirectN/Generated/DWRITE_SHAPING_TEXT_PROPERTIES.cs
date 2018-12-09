// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(2473,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_SHAPING_TEXT_PROPERTIES
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort isShapedAlone { get => InteropRuntime.GetUInt16(__bits, 0, 1); set => InteropRuntime.SetUInt16(value, __bits, 0, 1); }
        public ushort reserved1 { get => InteropRuntime.GetUInt16(__bits, 1, 1); set => InteropRuntime.SetUInt16(value, __bits, 1, 1); }
        public ushort canBreakShapingAfter { get => InteropRuntime.GetUInt16(__bits, 2, 1); set => InteropRuntime.SetUInt16(value, __bits, 2, 1); }
        public ushort reserved { get => InteropRuntime.GetUInt16(__bits, 3, 13); set => InteropRuntime.SetUInt16(value, __bits, 3, 13); }
    }
}
