// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_RENDERKM_COMMAND__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_GDIARG_BITBLT BitBlt {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_GDIARG_BITBLT>(__bits, 0, 576);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_DXGK_GDIARG_BITBLT>(value, __bits, 0, 576); } }
        public _DXGK_GDIARG_COLORFILL ColorFill {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_GDIARG_COLORFILL>(__bits, 0, 320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_DXGK_GDIARG_COLORFILL>(value, __bits, 0, 320); } }
        public _DXGK_GDIARG_ALPHABLEND AlphaBlend {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_GDIARG_ALPHABLEND>(__bits, 0, 512);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_DXGK_GDIARG_ALPHABLEND>(value, __bits, 0, 512); } }
        public _DXGK_GDIARG_STRETCHBLT StretchBlt {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_GDIARG_STRETCHBLT>(__bits, 0, 512);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_DXGK_GDIARG_STRETCHBLT>(value, __bits, 0, 512); } }
        public _DXGK_GDIARG_TRANSPARENTBLT TransparentBlt {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_GDIARG_TRANSPARENTBLT>(__bits, 0, 512);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_DXGK_GDIARG_TRANSPARENTBLT>(value, __bits, 0, 512); } }
        public _DXGK_GDIARG_CLEARTYPEBLEND ClearTypeBlend {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_GDIARG_CLEARTYPEBLEND>(__bits, 0, 576);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_DXGK_GDIARG_CLEARTYPEBLEND>(value, __bits, 0, 576); } }
    }
}
