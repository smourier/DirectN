// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(1090,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteFont interface represents a font in a font collection.
    /// </summary>
    [Guid("29748ed6-8c9c-4a6a-be0b-d912e8538944"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFont3
    {
        [PreserveSig]
        HRESULT CreateFontFace(/* _COM_Outptr_ */ out IDWriteFontFace3 fontFace);
        
        [PreserveSig]
        bool Equals(ref IDWriteFont font);
        
        [PreserveSig]
        HRESULT GetFontFaceReference(/* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        bool HasCharacter(uint unicodeValue);
        
        [PreserveSig]
        DWRITE_LOCALITY GetLocality();
    }
}
