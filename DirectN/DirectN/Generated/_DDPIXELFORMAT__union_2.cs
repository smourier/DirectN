// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(732,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDPIXELFORMAT__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint dwGBitMask => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwUBitMask => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwZBitMask => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwBumpDvBitMask => InteropRuntime.GetUInt32(__bits, 0, 32);
        public _DDPIXELFORMAT__union_2__struct_0 MultiSampleCaps => InteropRuntime.Get<_DDPIXELFORMAT__union_2__struct_0>(__bits, 0, 32);
    }
}
