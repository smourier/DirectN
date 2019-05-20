// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawint.h(792,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_SURFACE_LOCAL__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DDCOLORKEY ddckCKSrcOverlay { get => InteropRuntime.Get<_DDCOLORKEY>(__bits, 0, 64); set => InteropRuntime.Set<_DDCOLORKEY>(value, __bits, 0, 64); }
        public _DDCOLORKEY ddckCKSrcBlt { get => InteropRuntime.Get<_DDCOLORKEY>(__bits, 0, 64); set => InteropRuntime.Set<_DDCOLORKEY>(value, __bits, 0, 64); }
    }
}
