// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(253,9)
using System;

namespace DirectN
{
    /// <summary>
    /// Modifications made to the draw text call that influence how the text is rendered.
    /// </summary>
    [Flags]
    public enum D2D1_DRAW_TEXT_OPTIONS
    {
        /// <summary>
        /// Do not snap the baseline of the text vertically.
        /// </summary>
        D2D1_DRAW_TEXT_OPTIONS_NO_SNAP = 0x00000001,
        
        /// <summary>
        /// Clip the text to the content bounds.
        /// </summary>
        D2D1_DRAW_TEXT_OPTIONS_CLIP = 0x00000002,
        
        /// <summary>
        /// Render color versions of glyphs if defined by the font.
        /// </summary>
        D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT = 0x00000004,
        
        /// <summary>
        /// Bitmap origins of color glyph bitmaps are not snapped.
        /// </summary>
        D2D1_DRAW_TEXT_OPTIONS_DISABLE_COLOR_BITMAP_SNAPPING = 0x00000008,
        
        /// <summary>
        /// Bitmap origins of color glyph bitmaps are not snapped.
        /// </summary>
        D2D1_DRAW_TEXT_OPTIONS_NONE = 0x00000000,
        
        /// <summary>
        /// Bitmap origins of color glyph bitmaps are not snapped.
        /// </summary>
        D2D1_DRAW_TEXT_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
