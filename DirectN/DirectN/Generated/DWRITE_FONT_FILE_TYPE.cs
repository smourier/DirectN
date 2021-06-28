// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(37,1)
namespace DirectN
{
    /// <summary>
    /// The type of a font represented by a single font file. Font formats that consist of multiple files, e.g. Type 1 .PFM and .PFB, have separate enum values for each of the file type.
    /// </summary>
    public enum DWRITE_FONT_FILE_TYPE
    {
        /// <summary>
        /// Font type is not recognized by the DirectWrite font system.
        /// </summary>
        DWRITE_FONT_FILE_TYPE_UNKNOWN = 0,
        
        /// <summary>
        /// OpenType font with CFF outlines.
        /// </summary>
        DWRITE_FONT_FILE_TYPE_CFF = 1,
        
        /// <summary>
        /// OpenType font with TrueType outlines.
        /// </summary>
        DWRITE_FONT_FILE_TYPE_TRUETYPE = 2,
        
        /// <summary>
        /// OpenType font that contains a TrueType collection.
        /// </summary>
        DWRITE_FONT_FILE_TYPE_OPENTYPE_COLLECTION = 3,
        
        /// <summary>
        /// Type 1 PFM font.
        /// </summary>
        DWRITE_FONT_FILE_TYPE_TYPE1_PFM = 4,
        
        /// <summary>
        /// Type 1 PFB font.
        /// </summary>
        DWRITE_FONT_FILE_TYPE_TYPE1_PFB = 5,
        
        /// <summary>
        /// Vector .FON font.
        /// </summary>
        DWRITE_FONT_FILE_TYPE_VECTOR = 6,
        
        /// <summary>
        /// Bitmap .FON font.
        /// </summary>
        DWRITE_FONT_FILE_TYPE_BITMAP = 7,
        
        /// <summary>
        /// Bitmap .FON font.
        /// </summary>
        DWRITE_FONT_FILE_TYPE_TRUETYPE_COLLECTION = 3,
    }
}
