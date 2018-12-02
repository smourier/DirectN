// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(2473,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_SHAPING_TEXT_PROPERTIES
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] __bits;
        public ushort isShapedAlone => InteropRuntime.GetUInt16(__bits, 0, 1);
        public ushort reserved1 => InteropRuntime.GetUInt16(__bits, 1, 1);
        public ushort canBreakShapingAfter => InteropRuntime.GetUInt16(__bits, 2, 1);
        public ushort reserved => InteropRuntime.GetUInt16(__bits, 3, 13);
    }
}
