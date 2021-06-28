// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_2.h(525,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A font fallback definition used for mapping characters to fonts capable of supporting them.
    /// </summary>
    [ComImport, Guid("efa008f9-f7a1-48bf-b05c-f224713cc0ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFallback
    {
        [PreserveSig]
        HRESULT MapCharacters(IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, /* _In_opt_ */ IDWriteFontCollection baseFontCollection, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string baseFamilyName, DWRITE_FONT_WEIGHT baseWeight, DWRITE_FONT_STYLE baseStyle, DWRITE_FONT_STRETCH baseStretch, /* _Out_range_(0, textLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 0)] uint[] mappedLength, /* _COM_Outptr_result_maybenull_ */ out IDWriteFont mappedFont, /* _Out_ */ out float scale);
    }
}
