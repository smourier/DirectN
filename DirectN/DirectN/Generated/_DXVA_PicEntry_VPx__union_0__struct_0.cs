// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1310,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicEntry_VPx__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] __bits;
        public byte Index7Bits => InteropRuntime.GetByte(__bits, 0, 7);
        public byte AssociatedFlag => InteropRuntime.GetByte(__bits, 7, 1);
    }
}
