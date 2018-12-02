// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(588,5)
using System;
using System.Runtime.InteropServices;
using LPVMEMHEAP = DirectN._VMEMHEAP;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VIDMEM__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr lpHeap => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
        public uint dwHeight => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
