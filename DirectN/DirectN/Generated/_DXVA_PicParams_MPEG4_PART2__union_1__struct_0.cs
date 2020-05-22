// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(1123,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_MPEG4_PART2__union_1__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort sprite_enable { get => InteropRuntime.GetUInt16(__bits, 0, 2); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 2); } }
        public ushort no_of_sprite_warping_points { get => InteropRuntime.GetUInt16(__bits, 2, 6); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 2, 6); } }
        public ushort sprite_warping_accuracy { get => InteropRuntime.GetUInt16(__bits, 8, 2); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 8, 2); } }
    }
}
