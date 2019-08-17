// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dhal.h(656,5)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_SETRENDERTARGETDATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2040)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr lpDDS { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set => InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); }
        public IntPtr lpDDSLcl { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set => InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); }
    }
}
