// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_2.h(575,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Builder used to create a font fallback definition by appending a series of fallback mappings, followed by a creation call.  <remarks> This object may not be thread-safe. </remarks>
    /// </summary>
    [ComImport, Guid("fd882d06-8aba-4fb8-b849-8be8b73e14de"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFallbackBuilder
    {
        [PreserveSig]
        HRESULT AddMapping(/* _In_reads_(rangesCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_UNICODE_RANGE[] ranges, int rangesCount, /* _In_reads_(targetFamilyNamesCount) */ IntPtr targetFamilyNames, uint targetFamilyNamesCount, /* _In_opt_ */ IDWriteFontCollection fontCollection, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string baseFamilyName, float scale);
        
        [PreserveSig]
        HRESULT AddMappings(IDWriteFontFallback fontFallback);
        
        [PreserveSig]
        HRESULT CreateFontFallback(/* _COM_Outptr_ */ out IDWriteFontFallback fontFallback);
    }
}
