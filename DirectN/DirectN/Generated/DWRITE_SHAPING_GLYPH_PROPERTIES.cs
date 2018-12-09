// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(2502,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_SHAPING_GLYPH_PROPERTIES
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort justification { get => InteropRuntime.GetUInt16(__bits, 0, 4); set => InteropRuntime.SetUInt16(value, __bits, 0, 4); }
        public ushort isClusterStart { get => InteropRuntime.GetUInt16(__bits, 4, 1); set => InteropRuntime.SetUInt16(value, __bits, 4, 1); }
        public ushort isDiacritic { get => InteropRuntime.GetUInt16(__bits, 5, 1); set => InteropRuntime.SetUInt16(value, __bits, 5, 1); }
        public ushort isZeroWidthSpace { get => InteropRuntime.GetUInt16(__bits, 6, 1); set => InteropRuntime.SetUInt16(value, __bits, 6, 1); }
        public ushort reserved { get => InteropRuntime.GetUInt16(__bits, 7, 9); set => InteropRuntime.SetUInt16(value, __bits, 7, 9); }
    }
}
