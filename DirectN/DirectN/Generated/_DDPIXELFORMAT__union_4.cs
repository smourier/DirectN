// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(752,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDPIXELFORMAT__union_4
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint dwRGBAlphaBitMask => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwYUVAlphaBitMask => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwLuminanceAlphaBitMask => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwRGBZBitMask => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwYUVZBitMask => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
