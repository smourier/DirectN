// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmdt.h(542,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDEO_SIGNAL_INFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMDT_VIDEO_SIGNAL_INFO__union_0__struct_0 AdditionalSignalInfo { get => InteropRuntime.Get<_D3DKMDT_VIDEO_SIGNAL_INFO__union_0__struct_0>(__bits, 0, 32); set => InteropRuntime.Set<_D3DKMDT_VIDEO_SIGNAL_INFO__union_0__struct_0>(value, __bits, 0, 32); }
        public _D3DDDI_VIDEO_SIGNAL_SCANLINE_ORDERING ScanLineOrdering { get => InteropRuntime.Get<_D3DDDI_VIDEO_SIGNAL_SCANLINE_ORDERING>(__bits, 0, 32); set => InteropRuntime.Set<_D3DDDI_VIDEO_SIGNAL_SCANLINE_ORDERING>(value, __bits, 0, 32); }
    }
}
