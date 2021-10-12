// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(538,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Set of fonts used for creating font faces, selecting nearest matching fonts, and filtering. Unlike IDWriteFontFamily and IDWriteFontList, which are part of the IDWriteFontCollection heirarchy, font sets are unordered flat lists.
    /// </summary>
    [ComImport, Guid("53585141-d9f8-4095-8321-d73cf6bd116b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontSet
    {
        [PreserveSig]
        uint GetFontCount();
        
        [PreserveSig]
        HRESULT GetFontFaceReference(uint listIndex, /* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        HRESULT FindFontFaceReference(IDWriteFontFaceReference fontFaceReference, /* _Out_ */ out uint listIndex, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        HRESULT FindFontFace(IDWriteFontFace fontFace, /* _Out_ */ out uint listIndex, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        HRESULT GetPropertyValues(uint listIndex, DWRITE_FONT_PROPERTY_ID propertyId, /* _Out_ */ out bool exists, /* _COM_Outptr_result_maybenull_ */ out IDWriteLocalizedStrings values);
        
        [PreserveSig]
        HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, /* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string preferredLocaleNames, /* _COM_Outptr_ */ out IDWriteStringList values);
        
        [PreserveSig]
        HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, /* _COM_Outptr_ */ out IDWriteStringList values);
        
        [PreserveSig]
        HRESULT GetPropertyOccurrenceCount(/* _In_ */ ref DWRITE_FONT_PROPERTY property, /* _Out_ */ out uint propertyOccurrenceCount);
        
        [PreserveSig]
        HRESULT GetMatchingFonts(/* _In_reads_(propertyCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_PROPERTY[] properties, int propertyCount, /* _COM_Outptr_ */ out IDWriteFontSet filteredSet);
        
        [PreserveSig]
        HRESULT GetMatchingFonts(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, /* _COM_Outptr_ */ out IDWriteFontSet filteredSet);
    }
}
