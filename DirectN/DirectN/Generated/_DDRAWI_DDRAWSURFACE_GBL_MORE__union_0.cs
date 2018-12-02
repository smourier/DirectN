// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(1407,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWSURFACE_GBL_MORE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public uint dwPhysicalPageTable => InteropRuntime.GetUInt32(__bits, 0, 32);
        public ulong fpPhysicalVidMem => InteropRuntime.GetUInt6s(__bits, 0, 64);
    }
}
