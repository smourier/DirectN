// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcommon.h(62,1)
using System;

namespace DirectN
{
    /// <summary>
    /// Fonts may contain multiple drawable data formats for glyphs. These flags specify which formats are supported in the font, either at a font-wide level or per glyph, and the app may use them to tell DWrite which formats to return when splitting a color glyph run.
    /// </summary>
    [Flags]
    public enum DWRITE_GLYPH_IMAGE_FORMATS
    {
        /// <summary>
        /// Indicates no data is available for this glyph.
        /// </summary>
        DWRITE_GLYPH_IMAGE_FORMATS_NONE = 0x00000000,
        
        /// <summary>
        /// The glyph has TrueType outlines.
        /// </summary>
        DWRITE_GLYPH_IMAGE_FORMATS_TRUETYPE = 0x00000001,
        
        /// <summary>
        /// The glyph has CFF outlines.
        /// </summary>
        DWRITE_GLYPH_IMAGE_FORMATS_CFF = 0x00000002,
        
        /// <summary>
        /// The glyph has multilayered COLR data.
        /// </summary>
        DWRITE_GLYPH_IMAGE_FORMATS_COLR = 0x00000004,
        
        /// <summary>
        /// The glyph has SVG outlines as standard XML.  <remarks> Fonts may store the content gzip'd rather than plain text, indicated by the first two bytes as gzip header {0x1F 0x8B}. </remarks>
        /// </summary>
        DWRITE_GLYPH_IMAGE_FORMATS_SVG = 0x00000008,
        
        /// <summary>
        /// The glyph has PNG image data, with standard PNG IHDR.
        /// </summary>
        DWRITE_GLYPH_IMAGE_FORMATS_PNG = 0x00000010,
        
        /// <summary>
        /// The glyph has JPEG image data, with standard JIFF SOI header.
        /// </summary>
        DWRITE_GLYPH_IMAGE_FORMATS_JPEG = 0x00000020,
        
        /// <summary>
        /// The glyph has TIFF image data.
        /// </summary>
        DWRITE_GLYPH_IMAGE_FORMATS_TIFF = 0x00000040,
        
        /// <summary>
        /// The glyph has raw 32-bit premultiplied BGRA data.
        /// </summary>
        DWRITE_GLYPH_IMAGE_FORMATS_PREMULTIPLIED_B8G8R8A8 = 0x00000080,
    }
}
