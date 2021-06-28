// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(344,1)
namespace DirectN
{
    /// <summary>
    /// The informational string enumeration identifies a string in a font.
    /// </summary>
    public enum DWRITE_INFORMATIONAL_STRING_ID
    {
        /// <summary>
        /// Unspecified name ID.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_NONE = 0,
        
        /// <summary>
        /// Copyright notice provided by the font.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_COPYRIGHT_NOTICE = 1,
        
        /// <summary>
        /// String containing a version number.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_VERSION_STRINGS = 2,
        
        /// <summary>
        /// Trademark information provided by the font.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_TRADEMARK = 3,
        
        /// <summary>
        /// Name of the font manufacturer.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_MANUFACTURER = 4,
        
        /// <summary>
        /// Name of the font designer.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_DESIGNER = 5,
        
        /// <summary>
        /// URL of font designer (with protocol, e.g., http://, ftp://).
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_DESIGNER_URL = 6,
        
        /// <summary>
        /// Description of the font. Can contain revision information, usage recommendations, history, features, etc.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_DESCRIPTION = 7,
        
        /// <summary>
        /// URL of font vendor (with protocol, e.g., http://, ftp://). If a unique serial number is embedded in the URL, it can be used to register the font.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_FONT_VENDOR_URL = 8,
        
        /// <summary>
        /// Description of how the font may be legally used, or different example scenarios for licensed use. This field should be written in plain language, not legalese.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_LICENSE_DESCRIPTION = 9,
        
        /// <summary>
        /// URL where additional licensing information can be found.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_LICENSE_INFO_URL = 10,
        
        /// <summary>
        /// GDI-compatible family name. Because GDI allows a maximum of four fonts per family, fonts in the same family may have different GDI-compatible family names (e.g., "Arial", "Arial Narrow", "Arial Black").
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_WIN32_FAMILY_NAMES = 11,
        
        /// <summary>
        /// GDI-compatible subfamily name.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_WIN32_SUBFAMILY_NAMES = 12,
        
        /// <summary>
        /// Typographic family name preferred by the designer. This enables font designers to group more than four fonts in a single family without losing compatibility with GDI. This name is typically only present if it differs from the GDI-compatible family name.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_FAMILY_NAMES = 13,
        
        /// <summary>
        /// Typographic subfamily name preferred by the designer. This name is typically only present if it differs from the GDI-compatible subfamily name.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_SUBFAMILY_NAMES = 14,
        
        /// <summary>
        /// Sample text. This can be the font name or any other text that the designer thinks is the best example to display the font in.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_SAMPLE_TEXT = 15,
        
        /// <summary>
        /// The full name of the font, e.g. "Arial Bold", from name id 4 in the name table.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_FULL_NAME = 16,
        
        /// <summary>
        /// The postscript name of the font, e.g. "GillSans-Bold" from name id 6 in the name table.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_NAME = 17,
        
        /// <summary>
        /// The postscript CID findfont name, from name id 20 in the name table.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_CID_NAME = 18,
        
        /// <summary>
        /// Family name for the weight-stretch-style model.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_WEIGHT_STRETCH_STYLE_FAMILY_NAME = 19,
        
        /// <summary>
        /// Script/language tag to identify the scripts or languages that the font was primarily designed to support. See DWRITE_FONT_PROPERTY_ID_DESIGN_SCRIPT_LANGUAGE_TAG for a longer description.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_DESIGN_SCRIPT_LANGUAGE_TAG = 20,
        
        /// <summary>
        /// Script/language tag to identify the scripts or languages that the font declares it is able to support.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_SUPPORTED_SCRIPT_LANGUAGE_TAG = 21,
        
        /// <summary>
        /// Script/language tag to identify the scripts or languages that the font declares it is able to support.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_PREFERRED_FAMILY_NAMES = 13,
        
        /// <summary>
        /// Script/language tag to identify the scripts or languages that the font declares it is able to support.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_PREFERRED_SUBFAMILY_NAMES = 14,
        
        /// <summary>
        /// Script/language tag to identify the scripts or languages that the font declares it is able to support.
        /// </summary>
        DWRITE_INFORMATIONAL_STRING_WWS_FAMILY_NAME = 19,
    }
}
