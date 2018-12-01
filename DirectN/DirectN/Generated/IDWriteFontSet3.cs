// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(3598,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7c073ef2-a7f4-4045-8c32-8ab8ae640f90"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontSet3 : IDWriteFontSet2
    {
        // IDWriteFontSet
        [PreserveSig]
        new uint GetFontCount();
        
        [PreserveSig]
        new HRESULT GetFontFaceReference(uint listIndex, /* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        new HRESULT FindFontFaceReference(IDWriteFontFaceReference fontFaceReference, /* _Out_ */ out uint listIndex, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        new HRESULT FindFontFace(ref IDWriteFontFace fontFace, /* _Out_ */ out uint listIndex, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        new HRESULT GetPropertyValues(uint listIndex, DWRITE_FONT_PROPERTY_ID propertyId, /* _Out_ */ out bool exists, /* _COM_Outptr_result_maybenull_ */ out IDWriteLocalizedStrings values);
        
        [PreserveSig]
        new HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, /* _In_z_ */ ref char preferredLocaleNames, /* _COM_Outptr_ */ out IDWriteStringList values);
        
        [PreserveSig]
        new HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, /* _COM_Outptr_ */ out IDWriteStringList values);
        
        [PreserveSig]
        new HRESULT GetPropertyOccurrenceCount(/* _In_ */ ref DWRITE_FONT_PROPERTY property, /* _Out_ */ out uint propertyOccurrenceCount);
        
        [PreserveSig]
        new HRESULT GetMatchingFonts(/* _In_reads_(propertyCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_PROPERTY[] properties, uint propertyCount, /* _COM_Outptr_ */ out IDWriteFontSet filteredSet);
        
        [PreserveSig]
        new HRESULT GetMatchingFonts(/* _In_z_ */ ref char familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, /* _COM_Outptr_ */ out IDWriteFontSet filteredSet);
        
        // IDWriteFontSet1
        [PreserveSig]
        new HRESULT GetMatchingFonts(/* _In_opt_ */ ref DWRITE_FONT_PROPERTY fontProperty, /* _In_reads_(fontAxisValueCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, /* _COM_Outptr_ */ out IDWriteFontSet1 matchingFonts);
        
        [PreserveSig]
        new HRESULT GetFirstFontResources(/* _COM_Outptr_ */ out IDWriteFontSet1 filteredFontSet);
        
        [PreserveSig]
        new HRESULT GetFilteredFonts(/* _In_reads_opt_(propertyCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_PROPERTY[] properties, uint propertyCount, bool selectAnyProperty, /* _COM_Outptr_ */ out IDWriteFontSet1 filteredFontSet);
        
        [PreserveSig]
        new HRESULT GetFilteredFonts(/* _In_reads_(fontAxisRangeCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, uint fontAxisRangeCount, bool selectAnyRange, /* _COM_Outptr_ */ out IDWriteFontSet1 filteredFontSet);
        
        [PreserveSig]
        new HRESULT GetFilteredFonts(/* _In_reads_(indexCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] indices, uint indexCount, /* _COM_Outptr_ */ out IDWriteFontSet1 filteredFontSet);
        
        [PreserveSig]
        new HRESULT GetFilteredFontIndices(/* _In_reads_(propertyCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_PROPERTY[] properties, uint propertyCount, bool selectAnyProperty, /* _Out_writes_(maxIndexCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] indices, uint maxIndexCount, /* _Out_ */ out uint actualIndexCount);
        
        [PreserveSig]
        new HRESULT GetFilteredFontIndices(/* _In_reads_(fontAxisRangeCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, uint fontAxisRangeCount, bool selectAnyRange, /* _Out_writes_(maxIndexCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] indices, uint maxIndexCount, /* _Out_ */ out uint actualIndexCount);
        
        [PreserveSig]
        new HRESULT GetFontAxisRanges(/* _Out_writes_(maxFontAxisRangeCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, uint maxFontAxisRangeCount, /* _Out_ */ out uint actualFontAxisRangeCount);
        
        [PreserveSig]
        new HRESULT GetFontAxisRanges(uint listIndex, /* _Out_writes_(maxFontAxisRangeCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, uint maxFontAxisRangeCount, /* _Out_ */ out uint actualFontAxisRangeCount);
        
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
        new IntPtr GetExpirationEvent();
        
        // IDWriteFontSet3
        [PreserveSig]
        DWRITE_FONT_SOURCE_TYPE GetFontSourceType(uint fontIndex);
        
        [PreserveSig]
        uint GetFontSourceNameLength(uint listIndex);
        
        [PreserveSig]
        HRESULT GetFontSourceName(uint listIndex, /* _Out_writes_z_(stringBufferSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] char[] stringBuffer, uint stringBufferSize);
    }
}
