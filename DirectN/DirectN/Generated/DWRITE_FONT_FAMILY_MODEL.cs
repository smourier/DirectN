// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(2480,1)
namespace DirectN
{
    /// <summary>
    /// How font families are grouped together, used by IDWriteFontCollection.
    /// </summary>
    public enum DWRITE_FONT_FAMILY_MODEL
    {
        /// <summary>
        /// Families are grouped by the typographic family name preferred by the font author. The family can contain as many face as the font author wants. This corresponds to the DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FAMILY_NAME.
        /// </summary>
        DWRITE_FONT_FAMILY_MODEL_TYPOGRAPHIC = 0,
        
        /// <summary>
        /// Families are grouped by the weight-stretch-style family name, where all faces that differ only by those three axes are grouped into the same family, but any other axes go into a distinct family. For example, the Sitka family with six different optical sizes yields six separate families (Sitka Caption, Display, Text, Subheading, Heading, Banner...). This corresponds to the DWRITE_FONT_PROPERTY_ID_WEIGHT_STRETCH_STYLE_FAMILY_NAME.
        /// </summary>
        DWRITE_FONT_FAMILY_MODEL_WEIGHT_STRETCH_STYLE = 1,
    }
}
