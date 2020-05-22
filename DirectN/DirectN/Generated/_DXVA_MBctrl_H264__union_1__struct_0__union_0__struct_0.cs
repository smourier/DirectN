// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(861,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_MBctrl_H264__union_1__struct_0__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte intra_chroma_pred_mode { get => InteropRuntime.GetByte(__bits, 0, 2); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 2); } }
        public byte IntraPredAvailFlags { get => InteropRuntime.GetByte(__bits, 2, 5); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 2, 5); } }
        public byte ReservedIntraBit { get => InteropRuntime.GetByte(__bits, 7, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 7, 1); } }
    }
}
