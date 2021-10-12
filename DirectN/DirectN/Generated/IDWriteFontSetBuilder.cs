// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(721,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Builder interface to add font face references and create a font set.
    /// </summary>
    [ComImport, Guid("2f642afe-9c68-4f40-b8be-457401afcb3d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontSetBuilder
    {
        [PreserveSig]
        HRESULT AddFontFaceReference(/* _In_ */ IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        HRESULT AddFontFaceReference(/* _In_ */ IDWriteFontFaceReference fontFaceReference, /* _In_reads_(propertyCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FONT_PROPERTY[] properties, int propertyCount);
        
        [PreserveSig]
        HRESULT AddFontSet(/* _In_ */ IDWriteFontSet fontSet);
        
        [PreserveSig]
        HRESULT CreateFontSet(/* _COM_Outptr_ */ out IDWriteFontSet fontSet);
    }
}
