// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva.h(1143,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicEntry_HEVC__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte Index7Bits { get => InteropRuntime.GetByte(__bits, 0, 7); set => InteropRuntime.SetByte(value, __bits, 0, 7); }
        public byte AssociatedFlag { get => InteropRuntime.GetByte(__bits, 7, 1); set => InteropRuntime.SetByte(value, __bits, 7, 1); }
    }
}
