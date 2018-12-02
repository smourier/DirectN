// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxvahd.h(349,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_BLT_STATE_OUTPUT_COLOR_SPACE_DATA__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint Usage => InteropRuntime.GetUInt32(__bits, 0, 1);
        public uint RGB_Range => InteropRuntime.GetUInt32(__bits, 1, 1);
        public uint YCbCr_Matrix => InteropRuntime.GetUInt32(__bits, 2, 1);
        public uint YCbCr_xvYCC => InteropRuntime.GetUInt32(__bits, 3, 1);
        public uint Reserved => InteropRuntime.GetUInt32(__bits, 4, 28);
    }
}
