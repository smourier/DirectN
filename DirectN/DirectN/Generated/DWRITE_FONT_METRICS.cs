// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(472,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The DWRITE_FONT_METRICS structure specifies the metrics of a font face that are applicable to all glyphs within the font face.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_FONT_METRICS
    {
        /// <summary>
        /// The number of font design units per em unit. Font files use their own coordinate system of font design units. A font design unit is the smallest measurable unit in the em square, an imaginary square that is used to size and align glyphs. The concept of em square is used as a reference scale factor when defining font size and device transformation semantics. The size of one em square is also commonly used to compute the paragraph indentation value.
        /// </summary>
        public ushort designUnitsPerEm;
        /// <summary>
        /// Ascent value of the font face in font design units. Ascent is the distance from the top of font character alignment box to English baseline.
        /// </summary>
        public ushort ascent;
        /// <summary>
        /// Descent value of the font face in font design units. Descent is the distance from the bottom of font character alignment box to English baseline.
        /// </summary>
        public ushort descent;
        /// <summary>
        /// Line gap in font design units. Recommended additional white space to add between lines to improve legibility. The recommended line spacing (baseline-to-baseline distance) is thus the sum of ascent, descent, and lineGap. The line gap is usually positive or zero but can be negative, in which case the recommended line spacing is less than the height of the character alignment box.
        /// </summary>
        public short lineGap;
        /// <summary>
        /// Cap height value of the font face in font design units. Cap height is the distance from English baseline to the top of a typical English capital. Capital "H" is often used as a reference character for the purpose of calculating the cap height value.
        /// </summary>
        public ushort capHeight;
        /// <summary>
        /// x-height value of the font face in font design units. x-height is the distance from English baseline to the top of lowercase letter "x", or a similar lowercase character.
        /// </summary>
        public ushort xHeight;
        /// <summary>
        /// The underline position value of the font face in font design units. Underline position is the position of underline relative to the English baseline. The value is usually made negative in order to place the underline below the baseline.
        /// </summary>
        public short underlinePosition;
        /// <summary>
        /// The suggested underline thickness value of the font face in font design units.
        /// </summary>
        public ushort underlineThickness;
        /// <summary>
        /// The strikethrough position value of the font face in font design units. Strikethrough position is the position of strikethrough relative to the English baseline. The value is usually made positive in order to place the strikethrough above the baseline.
        /// </summary>
        public short strikethroughPosition;
        /// <summary>
        /// The suggested strikethrough thickness value of the font face in font design units.
        /// </summary>
        public ushort strikethroughThickness;
    }
}
