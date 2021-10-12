// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(3449,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2397599d-dd0d-4681-bd6a-f4f31eaade77"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFallback1 : IDWriteFontFallback
    {
        // IDWriteFontFallback
        [PreserveSig]
        new HRESULT MapCharacters(IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, /* _In_opt_ */ IDWriteFontCollection baseFontCollection, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string baseFamilyName, DWRITE_FONT_WEIGHT baseWeight, DWRITE_FONT_STYLE baseStyle, DWRITE_FONT_STRETCH baseStretch, /* _Out_range_(0, textLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 0)] uint[] mappedLength, /* _COM_Outptr_result_maybenull_ */ out IDWriteFont mappedFont, /* _Out_ */ out float scale);
        
        // IDWriteFontFallback1
    }
}
