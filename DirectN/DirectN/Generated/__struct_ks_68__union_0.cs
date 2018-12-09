// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ks.h(440,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_ks_68__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr ObjectHandle { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set => InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); }
        public IntPtr ObjectPointer { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set => InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); }
    }
}
