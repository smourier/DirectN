// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(897,3)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Deblock_H264__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] __bits;
        public _DXVA_Deblock_H264__union_0__struct_0 __field_0 => InteropRuntime.GetBits<_DXVA_Deblock_H264__union_0__struct_0>(__bits, 0, 8);
        public byte FirstByte => InteropRuntime.GetByteBits(__bits, 0, 8);
    }
}
