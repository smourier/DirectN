// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(712,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDPIXELFORMAT__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint dwRGBBitCount => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwYUVBitCount => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwZBufferBitDepth => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwAlphaBitDepth => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwLuminanceBitCount => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwBumpBitCount => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwPrivateFormatBitCount => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
    }
}
