// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(64,1)
namespace DirectN
{
    /// <summary>
    /// The font property enumeration identifies a string in a font.
    /// </summary>
    public enum DWRITE_FONT_PROPERTY_ID
    {
        /// <summary>
        /// Unspecified font property identifier.
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_NONE = 0,
        
        /// <summary>
        /// Family name for the weight-stretch-style model.
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FAMILY_NAME = 1,
        
        /// <summary>
        /// Family name preferred by the designer. This enables font designers to group more than four fonts in a single family without losing compatibility with GDI. This name is typically only present if it differs from the GDI-compatible family name.
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FAMILY_NAME = 2,
        
        /// <summary>
        /// Face name of the for the weight-stretch-style (e.g., Regular or Bold).
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FACE_NAME = 3,
        
        /// <summary>
        /// The full name of the font, e.g. "Arial Bold", from name id 4 in the name table.
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_FULL_NAME = 4,
        
        /// <summary>
        /// GDI-compatible family name. Because GDI allows a maximum of four fonts per family, fonts in the same family may have different GDI-compatible family names (e.g., "Arial", "Arial Narrow", "Arial Black").
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_WIN32_FAMILY_NAME = 5,
        
        /// <summary>
        /// The postscript name of the font, e.g. "GillSans-Bold" from name id 6 in the name table.
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_POSTSCRIPT_NAME = 6,
        
        /// <summary>
        /// Script/language tag to identify the scripts or languages that the font was primarily designed to support.  <remarks> The design script/language tag is meant to be understood from the perspective of users. For example, a font is considered designed for English if it is considered useful for English users. Note that this is different from what a font might be capable of supporting. For example, the Meiryo font was primarily designed for Japanese users. While it is capable of displaying English well, it was not meant to be offered for the benefit of non-Japanese-speaking English users.
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_DESIGN_SCRIPT_LANGUAGE_TAG = 7,
        
        /// <summary>
        /// Script/language tag to identify the scripts or languages that the font declares it is able to support.
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_SUPPORTED_SCRIPT_LANGUAGE_TAG = 8,
        
        /// <summary>
        /// Semantic tag to describe the font (e.g. Fancy, Decorative, Handmade, Sans-serif, Swiss, Pixel, Futuristic).
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_SEMANTIC_TAG = 9,
        
        /// <summary>
        /// Weight of the font represented as a decimal string in the range 1-999.  <remark> This enum is discouraged for use with IDWriteFontSetBuilder2 in favor of the more generic font axis DWRITE_FONT_AXIS_TAG_WEIGHT which supports higher precision and range. </remark>
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_WEIGHT = 10,
        
        /// <summary>
        /// Stretch of the font represented as a decimal string in the range 1-9.  <remark> This enum is discouraged for use with IDWriteFontSetBuilder2 in favor of the more generic font axis DWRITE_FONT_AXIS_TAG_WIDTH which supports higher precision and range. </remark>
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_STRETCH = 11,
        
        /// <summary>
        /// Style of the font represented as a decimal string in the range 0-2.  <remark> This enum is discouraged for use with IDWriteFontSetBuilder2 in favor of the more generic font axes DWRITE_FONT_AXIS_TAG_SLANT and DWRITE_FONT_AXIS_TAG_ITAL. </remark>
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_STYLE = 12,
        
        /// <summary>
        /// Face name preferred by the designer. This enables font designers to group more than four fonts in a single family without losing compatibility with GDI.
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FACE_NAME = 13,
        
        /// <summary>
        /// Total number of properties for NTDDI_WIN10 (IDWriteFontSet).  <remarks> DWRITE_FONT_PROPERTY_ID_TOTAL cannot be used as a property ID. </remarks>
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_TOTAL = 13,
        
        /// <summary>
        /// Total number of properties for NTDDI_WIN10_RS3 (IDWriteFontSet1).
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_TOTAL_RS3 = 14,
        
        /// <summary>
        /// Total number of properties for NTDDI_WIN10_RS3 (IDWriteFontSet1).
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_PREFERRED_FAMILY_NAME = 2,
        
        /// <summary>
        /// Total number of properties for NTDDI_WIN10_RS3 (IDWriteFontSet1).
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_FAMILY_NAME = 1,
        
        /// <summary>
        /// Total number of properties for NTDDI_WIN10_RS3 (IDWriteFontSet1).
        /// </summary>
        DWRITE_FONT_PROPERTY_ID_FACE_NAME = 3,
    }
}
