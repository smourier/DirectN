// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(2502,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_SHAPING_GLYPH_PROPERTIES
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] __bits;
        public ushort justification => InteropRuntime.GetUInt16(__bits, 0, 4);
        public ushort isClusterStart => InteropRuntime.GetUInt16(__bits, 4, 1);
        public ushort isDiacritic => InteropRuntime.GetUInt16(__bits, 5, 1);
        public ushort isZeroWidthSpace => InteropRuntime.GetUInt16(__bits, 6, 1);
        public ushort reserved => InteropRuntime.GetUInt16(__bits, 7, 9);
    }
}
