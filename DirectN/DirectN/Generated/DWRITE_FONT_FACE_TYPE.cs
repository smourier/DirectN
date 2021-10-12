// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(88,1)
namespace DirectN
{
    /// <summary>
    /// The file format of a complete font face. Font formats that consist of multiple files, e.g. Type 1 .PFM and .PFB, have a single enum entry.
    /// </summary>
    public enum DWRITE_FONT_FACE_TYPE
    {
        /// <summary>
        /// OpenType font face with CFF outlines.
        /// </summary>
        DWRITE_FONT_FACE_TYPE_CFF = 0,
        
        /// <summary>
        /// OpenType font face with TrueType outlines.
        /// </summary>
        DWRITE_FONT_FACE_TYPE_TRUETYPE = 1,
        
        /// <summary>
        /// OpenType font face that is a part of a TrueType or CFF collection.
        /// </summary>
        DWRITE_FONT_FACE_TYPE_OPENTYPE_COLLECTION = 2,
        
        /// <summary>
        /// A Type 1 font face.
        /// </summary>
        DWRITE_FONT_FACE_TYPE_TYPE1 = 3,
        
        /// <summary>
        /// A vector .FON format font face.
        /// </summary>
        DWRITE_FONT_FACE_TYPE_VECTOR = 4,
        
        /// <summary>
        /// A bitmap .FON format font face.
        /// </summary>
        DWRITE_FONT_FACE_TYPE_BITMAP = 5,
        
        /// <summary>
        /// Font face type is not recognized by the DirectWrite font system.
        /// </summary>
        DWRITE_FONT_FACE_TYPE_UNKNOWN = 6,
        
        /// <summary>
        /// The font data includes only the CFF table from an OpenType CFF font. This font face type can be used only for embedded fonts (i.e., custom font file loaders) and the resulting font face object supports only the minimum functionality necessary to render glyphs.
        /// </summary>
        DWRITE_FONT_FACE_TYPE_RAW_CFF = 7,
        
        /// <summary>
        /// The font data includes only the CFF table from an OpenType CFF font. This font face type can be used only for embedded fonts (i.e., custom font file loaders) and the resulting font face object supports only the minimum functionality necessary to render glyphs.
        /// </summary>
        DWRITE_FONT_FACE_TYPE_TRUETYPE_COLLECTION = 2,
    }
}
