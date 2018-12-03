// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_2.h(639,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DCOLORVALUE__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public float b => InteropRuntime.GetSingle(__bits, 0, 32);
        public float dvB => InteropRuntime.GetSingle(__bits, 0, 32);
    }
}
