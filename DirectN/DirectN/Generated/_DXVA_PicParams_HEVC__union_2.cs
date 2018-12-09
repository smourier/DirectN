// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1210,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_HEVC__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXVA_PicParams_HEVC__union_2__struct_0 __field_0 { get => InteropRuntime.Get<_DXVA_PicParams_HEVC__union_2__struct_0>(__bits, 0, 32); set => InteropRuntime.Set<_DXVA_PicParams_HEVC__union_2__struct_0>(value, __bits, 0, 32); }
        public uint dwCodingSettingPicturePropertyFlags { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
    }
}
