// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(2425,1)
namespace DirectN
{
    /// <summary>
    /// How to apply number substitution on digits and related punctuation.
    /// </summary>
    public enum DWRITE_NUMBER_SUBSTITUTION_METHOD
    {
        /// <summary>
        /// Specifies that the substitution method should be determined based on LOCALE_IDIGITSUBSTITUTION value of the specified text culture.
        /// </summary>
        DWRITE_NUMBER_SUBSTITUTION_METHOD_FROM_CULTURE = 0,
        
        /// <summary>
        /// If the culture is Arabic or Farsi, specifies that the number shape depend on the context. Either traditional or nominal number shape are used depending on the nearest preceding strong character or (if there is none) the reading direction of the paragraph.
        /// </summary>
        DWRITE_NUMBER_SUBSTITUTION_METHOD_CONTEXTUAL = 1,
        
        /// <summary>
        /// Specifies that code points 0x30-0x39 are always rendered as nominal numeral shapes (ones of the European number), i.e., no substitution is performed.
        /// </summary>
        DWRITE_NUMBER_SUBSTITUTION_METHOD_NONE = 2,
        
        /// <summary>
        /// Specifies that number are rendered using the national number shape as specified by the LOCALE_SNATIVEDIGITS value of the specified text culture.
        /// </summary>
        DWRITE_NUMBER_SUBSTITUTION_METHOD_NATIONAL = 3,
        
        /// <summary>
        /// Specifies that number are rendered using the traditional shape for the specified culture. For most cultures, this is the same as NativeNational. However, NativeNational results in Latin number for some Arabic cultures, whereas this value results in Arabic number for all Arabic cultures.
        /// </summary>
        DWRITE_NUMBER_SUBSTITUTION_METHOD_TRADITIONAL = 4,
    }
}
