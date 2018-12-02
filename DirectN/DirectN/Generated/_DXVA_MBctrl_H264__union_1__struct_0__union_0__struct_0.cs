// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(855,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_MBctrl_H264__union_1__struct_0__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] __bits;
        public byte intra_chroma_pred_mode => InteropRuntime.GetByte(__bits, 0, 2);
        public byte IntraPredAvailFlags => InteropRuntime.GetByte(__bits, 2, 5);
        public byte ReservedIntraBit => InteropRuntime.GetByte(__bits, 7, 1);
    }
}
