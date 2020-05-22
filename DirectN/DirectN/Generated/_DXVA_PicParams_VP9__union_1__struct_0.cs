// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(1378,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_VP9__union_1__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte mode_ref_delta_enabled { get => InteropRuntime.GetByte(__bits, 0, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 1); } }
        public byte mode_ref_delta_update { get => InteropRuntime.GetByte(__bits, 1, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 1, 1); } }
        public byte use_prev_in_find_mv_refs { get => InteropRuntime.GetByte(__bits, 2, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 2, 1); } }
        public byte ReservedControlInfo5Bits { get => InteropRuntime.GetByte(__bits, 3, 5); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 3, 5); } }
    }
}
