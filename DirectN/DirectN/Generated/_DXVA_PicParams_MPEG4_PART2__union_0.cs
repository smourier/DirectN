// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1100,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_MPEG4_PART2__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXVA_PicParams_MPEG4_PART2__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_DXVA_PicParams_MPEG4_PART2__union_0__struct_0>(__bits, 0, 16); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.Set<_DXVA_PicParams_MPEG4_PART2__union_0__struct_0>(value, __bits, 0, 16); } }
        public ushort wPicFlagBitFields { get => InteropRuntime.GetUInt16(__bits, 0, 16); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 16); } }
    }
}
