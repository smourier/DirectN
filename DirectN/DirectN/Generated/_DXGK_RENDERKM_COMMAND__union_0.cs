// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_RENDERKM_COMMAND__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_GDIARG_BITBLT BitBlt { get => InteropRuntime.Get<_DXGK_GDIARG_BITBLT>(__bits, 0, 672); set { if (__bits == null) __bits = new byte[88]; InteropRuntime.Set<_DXGK_GDIARG_BITBLT>(value, __bits, 0, 672); } }
        public _DXGK_GDIARG_COLORFILL ColorFill { get => InteropRuntime.Get<_DXGK_GDIARG_COLORFILL>(__bits, 0, 384); set { if (__bits == null) __bits = new byte[88]; InteropRuntime.Set<_DXGK_GDIARG_COLORFILL>(value, __bits, 0, 384); } }
        public _DXGK_GDIARG_ALPHABLEND AlphaBlend { get => InteropRuntime.Get<_DXGK_GDIARG_ALPHABLEND>(__bits, 0, 640); set { if (__bits == null) __bits = new byte[88]; InteropRuntime.Set<_DXGK_GDIARG_ALPHABLEND>(value, __bits, 0, 640); } }
        public _DXGK_GDIARG_STRETCHBLT StretchBlt { get => InteropRuntime.Get<_DXGK_GDIARG_STRETCHBLT>(__bits, 0, 640); set { if (__bits == null) __bits = new byte[88]; InteropRuntime.Set<_DXGK_GDIARG_STRETCHBLT>(value, __bits, 0, 640); } }
        public _DXGK_GDIARG_TRANSPARENTBLT TransparentBlt { get => InteropRuntime.Get<_DXGK_GDIARG_TRANSPARENTBLT>(__bits, 0, 576); set { if (__bits == null) __bits = new byte[88]; InteropRuntime.Set<_DXGK_GDIARG_TRANSPARENTBLT>(value, __bits, 0, 576); } }
        public _DXGK_GDIARG_CLEARTYPEBLEND ClearTypeBlend { get => InteropRuntime.Get<_DXGK_GDIARG_CLEARTYPEBLEND>(__bits, 0, 704); set { if (__bits == null) __bits = new byte[88]; InteropRuntime.Set<_DXGK_GDIARG_CLEARTYPEBLEND>(value, __bits, 0, 704); } }
    }
}
