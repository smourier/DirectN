// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(2236,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSURFACEDESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public int lPitch => InteropRuntime.GetInt32(__bits, 0, 32);
        public uint dwLinearSize => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
