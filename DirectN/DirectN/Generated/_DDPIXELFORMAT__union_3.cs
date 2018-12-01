// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(745,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDPIXELFORMAT__union_3
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint dwBBitMask => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwVBitMask => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwStencilBitMask => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwBumpLuminanceBitMask => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
    }
}
