// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(3448,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2397599d-dd0d-4681-bd6a-f4f31eaade77"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFallback1
    {
        [PreserveSig]
        HRESULT MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, /* _In_opt_ */ ref IDWriteFontCollection baseFontCollection, /* _In_opt_z_ */ ref char baseFamilyName, /* _In_reads_(fontAxisValueCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, /* _Deref_out_range_(0, textLength) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] uint[] mappedLength, /* _Out_ */ out float scale, /* _COM_Outptr_ */ out IDWriteFontFace5 mappedFontFace);
    }
}
