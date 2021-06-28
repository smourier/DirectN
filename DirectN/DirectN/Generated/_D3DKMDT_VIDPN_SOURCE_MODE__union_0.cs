// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(332,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDPN_SOURCE_MODE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMDT_GRAPHICS_RENDERING_FORMAT Graphics { get => InteropRuntime.Get<_D3DKMDT_GRAPHICS_RENDERING_FORMAT>(__bits, 0, 256); set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<_D3DKMDT_GRAPHICS_RENDERING_FORMAT>(value, __bits, 0, 256); } }
        public _D3DKMDT_TEXT_RENDERING_FORMAT Text { get => InteropRuntime.Get<_D3DKMDT_TEXT_RENDERING_FORMAT>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<_D3DKMDT_TEXT_RENDERING_FORMAT>(value, __bits, 0, 32); } }
    }
}
