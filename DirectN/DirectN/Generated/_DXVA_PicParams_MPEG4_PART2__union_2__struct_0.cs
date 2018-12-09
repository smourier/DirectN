// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1126,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_MPEG4_PART2__union_2__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte vop_fcode_forward { get => InteropRuntime.GetByte(__bits, 0, 3); set => InteropRuntime.SetByte(value, __bits, 0, 3); }
        public byte vop_fcode_backward { get => InteropRuntime.GetByte(__bits, 3, 3); set => InteropRuntime.SetByte(value, __bits, 3, 3); }
    }
}
