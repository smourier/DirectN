// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_3.h(226,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Font property used for filtering font sets and building a font set with explicit properties.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_FONT_PROPERTY
    {
        /// <summary>
        /// Specifies the requested font property, such as DWRITE_FONT_PROPERTY_ID_FAMILY_NAME.
        /// </summary>
        public DWRITE_FONT_PROPERTY_ID propertyId;
        /// <summary>
        /// Specifies the property value, such as "Segoe UI".
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char propertyValue;
        /// <summary>
        /// Specifies the language / locale to use, such as "en-US".  <remarks> When passing property information to AddFontFaceReference, localeName indicates the language of the property value. BCP 47 language tags should be used. If a property value is inherently non-linguistic, this can be left empty.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char localeName;
    }
}
