// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(3247,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3ed49e77-a398-4261-b9cf-c126c2131ef3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFamily2 : IDWriteFontFamily1
    {
        // IDWriteFontFamily1
        [PreserveSig]
        new DWRITE_LOCALITY GetFontLocality(uint listIndex);
        
        [PreserveSig]
        new HRESULT GetFont(uint listIndex, /* _COM_Outptr_ */ out IDWriteFont3 font);
        
        [PreserveSig]
        new HRESULT GetFontFaceReference(uint listIndex, /* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
        // IDWriteFontFamily2
        [PreserveSig]
        HRESULT GetMatchingFonts(/* _In_reads_(fontAxisValueCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, /* _COM_Outptr_ */ out IDWriteFontList2 matchingFonts);
        
        [PreserveSig]
        HRESULT GetFontSet(/* _COM_Outptr_ */ out IDWriteFontSet1 fontSet);
    }
}
