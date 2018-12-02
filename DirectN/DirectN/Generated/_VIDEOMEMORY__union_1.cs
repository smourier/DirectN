// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(292,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VIDEOMEMORY__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr lpHeap => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
        public uint dwHeight => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
