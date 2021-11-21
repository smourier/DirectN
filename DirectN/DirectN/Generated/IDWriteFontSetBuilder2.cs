// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(2954,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ee5ba612-b131-463c-8f4f-3189b9401e45"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontSetBuilder2 : IDWriteFontSetBuilder1
    {
        // IDWriteFontSetBuilder
        [PreserveSig]
        new HRESULT AddFontFaceReference(/* _In_ */ IDWriteFontFaceReference fontFaceReference, /* _In_reads_(propertyCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FONT_PROPERTY[] properties, int propertyCount);
        
        [PreserveSig]
        new HRESULT AddFontFaceReference(/* _In_ */ IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        new HRESULT AddFontSet(/* _In_ */ IDWriteFontSet fontSet);
        
        [PreserveSig]
        new HRESULT CreateFontSet(/* _COM_Outptr_ */ out IDWriteFontSet fontSet);
        
        // IDWriteFontSetBuilder1
        [PreserveSig]
        new HRESULT AddFontFile(/* _In_ */ IDWriteFontFile fontFile);
        
        // IDWriteFontSetBuilder2
        [PreserveSig]
        HRESULT AddFont(/* _In_ */ IDWriteFontFile fontFile, uint fontFaceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, /* _In_reads_(fontAxisValueCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, int fontAxisValueCount, /* _In_reads_(fontAxisRangeCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, int fontAxisRangeCount, /* _In_reads_(propertyCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] DWRITE_FONT_PROPERTY[] properties, int propertyCount);
        
        [PreserveSig]
        HRESULT AddFontFile(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string filePath);
    }
}
