// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(10385,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_PROCESSOR_COLOR_SPACE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint Usage => InteropRuntime.GetUInt32Bits(__bits, 0, 1);
        public uint RGB_Range => InteropRuntime.GetUInt32Bits(__bits, 1, 1);
        public uint YCbCr_Matrix => InteropRuntime.GetUInt32Bits(__bits, 2, 1);
        public uint YCbCr_xvYCC => InteropRuntime.GetUInt32Bits(__bits, 3, 1);
        public uint Nominal_Range => InteropRuntime.GetUInt32Bits(__bits, 4, 2);
        public uint Reserved => InteropRuntime.GetUInt32Bits(__bits, 6, 26);
    }
}
