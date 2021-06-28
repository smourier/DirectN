// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_1.h(627,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_FONT_METRICS1
    {
        // struct DWRITE_FONT_METRICS
        public ushort designUnitsPerEm;
        public ushort ascent;
        public ushort descent;
        public short lineGap;
        public ushort capHeight;
        public ushort xHeight;
        public short underlinePosition;
        public ushort underlineThickness;
        public short strikethroughPosition;
        public ushort strikethroughThickness;
        
        // DWRITE_FONT_METRICS1
        /// <summary>
        /// Left edge of accumulated bounding blackbox of all glyphs in the font.
        /// </summary>
        public short glyphBoxLeft;
        /// <summary>
        /// Top edge of accumulated bounding blackbox of all glyphs in the font.
        /// </summary>
        public short glyphBoxTop;
        /// <summary>
        /// Right edge of accumulated bounding blackbox of all glyphs in the font.
        /// </summary>
        public short glyphBoxRight;
        /// <summary>
        /// Bottom edge of accumulated bounding blackbox of all glyphs in the font.
        /// </summary>
        public short glyphBoxBottom;
        /// <summary>
        /// Horizontal position of the subscript relative to the baseline origin. This is typically negative (to the left) in italic/oblique fonts, and zero in regular fonts.
        /// </summary>
        public short subscriptPositionX;
        /// <summary>
        /// Vertical position of the subscript relative to the baseline. This is typically negative.
        /// </summary>
        public short subscriptPositionY;
        /// <summary>
        /// Horizontal size of the subscript em box in design units, used to scale the simulated subscript relative to the full em box size. This the numerator of the scaling ratio where denominator is the design units per em. If this member is zero, the font does not specify a scale factor, and the client should use its own policy.
        /// </summary>
        public short subscriptSizeX;
        /// <summary>
        /// Vertical size of the subscript em box in design units, used to scale the simulated subscript relative to the full em box size. This the numerator of the scaling ratio where denominator is the design units per em. If this member is zero, the font does not specify a scale factor, and the client should use its own policy.
        /// </summary>
        public short subscriptSizeY;
        /// <summary>
        /// Horizontal position of the superscript relative to the baseline origin. This is typically positive (to the right) in italic/oblique fonts, and zero in regular fonts.
        /// </summary>
        public short superscriptPositionX;
        /// <summary>
        /// Vertical position of the superscript relative to the baseline. This is typically positive.
        /// </summary>
        public short superscriptPositionY;
        /// <summary>
        /// Horizontal size of the superscript em box in design units, used to scale the simulated superscript relative to the full em box size. This the numerator of the scaling ratio where denominator is the design units per em. If this member is zero, the font does not specify a scale factor, and the client should use its own policy.
        /// </summary>
        public short superscriptSizeX;
        /// <summary>
        /// Vertical size of the superscript em box in design units, used to scale the simulated superscript relative to the full em box size. This the numerator of the scaling ratio where denominator is the design units per em. If this member is zero, the font does not specify a scale factor, and the client should use its own policy.
        /// </summary>
        public short superscriptSizeY;
        /// <summary>
        /// Indicates that the ascent, descent, and lineGap are based on newer 'typographic' values in the font, rather than legacy values.
        /// </summary>
        public bool hasTypographicMetrics;
    }
}
