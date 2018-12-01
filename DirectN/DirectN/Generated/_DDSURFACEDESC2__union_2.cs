// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(2278,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSURFACEDESC2__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint dwMipMapCount => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwRefreshRate => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwSrcVBHandle => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
    }
}
