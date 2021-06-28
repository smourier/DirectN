// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(292,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VIDEOMEMORY__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr lpHeap { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public uint dwHeight { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
