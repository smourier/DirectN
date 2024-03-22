// generated from <Windows SDK Path>\um\dwrite_3.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Specifies type-specific properties of the paint element.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAINT_UNION
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public PAINT_LAYERS layers {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<PAINT_LAYERS>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<PAINT_LAYERS>(value, __bits, 0, 32); } }
        public PAINT_SOLID_GLYPH solidGlyph {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<PAINT_SOLID_GLYPH>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<PAINT_SOLID_GLYPH>(value, __bits, 0, 256); } }
        /// <summary>
        /// Valid for paint elements of type DWRITE_PAINT_TYPE_SOLID. Specifies a solid color used to fill the current shape or clip. This paint element has no child elements.  <remarks> This corresponds to a PaintSolid or PaintVarSolid record in the OpenType COLR table. </remarks>
        /// </summary>
        public DWRITE_PAINT_COLOR solid {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<DWRITE_PAINT_COLOR>(__bits, 0, 224);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<DWRITE_PAINT_COLOR>(value, __bits, 0, 224); } }
        public PAINT_LINEAR_GRADIENT linearGradient {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<PAINT_LINEAR_GRADIENT>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<PAINT_LINEAR_GRADIENT>(value, __bits, 0, 256); } }
        public PAINT_RADIAL_GRADIENT radialGradient {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<PAINT_RADIAL_GRADIENT>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<PAINT_RADIAL_GRADIENT>(value, __bits, 0, 256); } }
        public PAINT_SWEEP_GRADIENT sweepGradient {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<PAINT_SWEEP_GRADIENT>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<PAINT_SWEEP_GRADIENT>(value, __bits, 0, 192); } }
        public PAINT_GLYPH glyph {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<PAINT_GLYPH>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<PAINT_GLYPH>(value, __bits, 0, 32); } }
        public PAINT_COLOR_GLYPH colorGlyph {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<PAINT_COLOR_GLYPH>(__bits, 0, 160);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<PAINT_COLOR_GLYPH>(value, __bits, 0, 160); } }
        /// <summary>
        /// Valid for paint elements of type DWRITE_PAINT_TYPE_TRANSFORM. Specifies an affine transform to be applied to child content. This paint element has one child element, which is the transformed content.  <remarks> This corresponds to paint formats 12 through 31 in the OpenType COLR table. </remarks>
        /// </summary>
        public DWRITE_MATRIX transform {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<DWRITE_MATRIX>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<DWRITE_MATRIX>(value, __bits, 0, 192); } }
        public PAINT_COMPOSITE composite {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<PAINT_COMPOSITE>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<PAINT_COMPOSITE>(value, __bits, 0, 32); } }
    }
}
