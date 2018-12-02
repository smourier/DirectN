// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1419,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_VP8__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] __bits;
        public byte frame_type => InteropRuntime.GetByte(__bits, 0, 1);
        public byte version => InteropRuntime.GetByte(__bits, 1, 3);
        public byte show_frame => InteropRuntime.GetByte(__bits, 4, 1);
        public byte clamp_type => InteropRuntime.GetByte(__bits, 5, 1);
        public byte ReservedFrameTag3Bits => InteropRuntime.GetByte(__bits, 6, 2);
    }
}
