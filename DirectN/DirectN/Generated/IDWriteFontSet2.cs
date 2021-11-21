// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(3491,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dc7ead19-e54c-43af-b2da-4e2b79ba3f7f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontSet2 : IDWriteFontSet1
    {
        // IDWriteFontSet
        [PreserveSig]
        new uint GetFontCount();
        
        [PreserveSig]
        new HRESULT GetFontFaceReference(uint listIndex, /* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        new HRESULT FindFontFaceReference(IDWriteFontFaceReference fontFaceReference, /* _Out_ */ out uint listIndex, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        new HRESULT FindFontFace(IDWriteFontFace fontFace, /* _Out_ */ out uint listIndex, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        new HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, /* _COM_Outptr_ */ out IDWriteStringList values);
        
        [PreserveSig]
        new HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, /* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string preferredLocaleNames, /* _COM_Outptr_ */ out IDWriteStringList values);
        
        [PreserveSig]
        new HRESULT GetPropertyValues(uint listIndex, DWRITE_FONT_PROPERTY_ID propertyId, /* _Out_ */ out bool exists, /* _COM_Outptr_result_maybenull_ */ out IDWriteLocalizedStrings values);
        
        [PreserveSig]
        new HRESULT GetPropertyOccurrenceCount(/* _In_ */ ref DWRITE_FONT_PROPERTY property, /* _Out_ */ out uint propertyOccurrenceCount);
        
        [PreserveSig]
        new HRESULT GetMatchingFonts(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, /* _COM_Outptr_ */ out IDWriteFontSet filteredSet);
        
        [PreserveSig]
        new HRESULT GetMatchingFonts(/* _In_reads_(propertyCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_PROPERTY[] properties, int propertyCount, /* _COM_Outptr_ */ out IDWriteFontSet filteredSet);
        
        // IDWriteFontSet1
        [PreserveSig]
        new HRESULT GetMatchingFonts(/* optional(DWRITE_FONT_PROPERTY) */ IntPtr fontProperty, /* _In_reads_(fontAxisValueCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, int fontAxisValueCount, /* _COM_Outptr_ */ out IDWriteFontSet1 matchingFonts);
        
        [PreserveSig]
        new HRESULT GetFirstFontResources(/* _COM_Outptr_ */ out IDWriteFontSet1 filteredFontSet);
        
        [PreserveSig]
        new HRESULT GetFilteredFonts(/* _In_reads_(indexCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] indices, int indexCount, /* _COM_Outptr_ */ out IDWriteFontSet1 filteredFontSet);
        
        [PreserveSig]
        new HRESULT GetFilteredFonts(/* _In_reads_(fontAxisRangeCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, int fontAxisRangeCount, bool selectAnyRange, /* _COM_Outptr_ */ out IDWriteFontSet1 filteredFontSet);
        
        [PreserveSig]
        new HRESULT GetFilteredFonts(/* _In_reads_opt_(propertyCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_PROPERTY[] properties, int propertyCount, bool selectAnyProperty, /* _COM_Outptr_ */ out IDWriteFontSet1 filteredFontSet);
        
        [PreserveSig]
        new HRESULT GetFilteredFontIndices(/* _In_reads_(fontAxisRangeCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, int fontAxisRangeCount, bool selectAnyRange, /* _Out_writes_(maxIndexCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] indices, int maxIndexCount, /* _Out_ */ out uint actualIndexCount);
        
        [PreserveSig]
        new HRESULT GetFilteredFontIndices(/* _In_reads_(propertyCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_PROPERTY[] properties, int propertyCount, bool selectAnyProperty, /* _Out_writes_(maxIndexCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] indices, int maxIndexCount, /* _Out_ */ out uint actualIndexCount);
        
        [PreserveSig]
        new HRESULT GetFontAxisRanges(uint listIndex, /* _Out_writes_(maxFontAxisRangeCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, int maxFontAxisRangeCount, /* _Out_ */ out uint actualFontAxisRangeCount);
        
        [PreserveSig]
        new HRESULT GetFontAxisRanges(/* _Out_writes_(maxFontAxisRangeCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, int maxFontAxisRangeCount, /* _Out_ */ out uint actualFontAxisRangeCount);
        
        [PreserveSig]
        new HRESULT GetFontFaceReference(uint listIndex, /* _COM_Outptr_ */ out IDWriteFontFaceReference1 fontFaceReference);
        
        [PreserveSig]
        new HRESULT CreateFontResource(uint listIndex, /* _COM_Outptr_ */ out IDWriteFontResource fontResource);
        
        [PreserveSig]
        new HRESULT CreateFontFace(uint listIndex, /* _COM_Outptr_ */ out IDWriteFontFace5 fontFace);
        
        [PreserveSig]
        new DWRITE_LOCALITY GetFontLocality(uint listIndex);
        
        // IDWriteFontSet2
        [PreserveSig]
        IntPtr GetExpirationEvent();
    }
}
