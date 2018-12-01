// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(2296,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSURFACEDESC2__union_4
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] __bits;
        public _DDPIXELFORMAT ddpfPixelFormat => InteropRuntime.GetBits<_DDPIXELFORMAT>(__bits, 0, 256);
        public uint dwFVF => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
    }
}
