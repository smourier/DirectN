// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(797,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_SURFACE_LOCAL__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DDCOLORKEY ddckCKDestOverlay { get => InteropRuntime.Get<_DDCOLORKEY>(__bits, 0, 64); set => InteropRuntime.Set<_DDCOLORKEY>(value, __bits, 0, 64); }
        public _DDCOLORKEY ddckCKDestBlt { get => InteropRuntime.Get<_DDCOLORKEY>(__bits, 0, 64); set => InteropRuntime.Set<_DDCOLORKEY>(value, __bits, 0, 64); }
    }
}
