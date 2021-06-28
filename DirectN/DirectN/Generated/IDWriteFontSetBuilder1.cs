// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_3.h(2047,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3ff7715f-3cdc-4dc6-9b72-ec5621dccafd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontSetBuilder1 : IDWriteFontSetBuilder
    {
        // IDWriteFontSetBuilder
        [PreserveSig]
        new HRESULT AddFontFaceReference(/* _In_ */ IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        new HRESULT AddFontFaceReference(/* _In_ */ IDWriteFontFaceReference fontFaceReference, /* _In_reads_(propertyCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FONT_PROPERTY[] properties, int propertyCount);
        
        [PreserveSig]
        new HRESULT AddFontSet(/* _In_ */ IDWriteFontSet fontSet);
        
        [PreserveSig]
        new HRESULT CreateFontSet(/* _COM_Outptr_ */ out IDWriteFontSet fontSet);
        
        // IDWriteFontSetBuilder1
        [PreserveSig]
        HRESULT AddFontFile(/* _In_ */ IDWriteFontFile fontFile);
    }
}
