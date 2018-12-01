// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_2.h(435,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The text analyzer interface represents a set of application-defined callbacks that perform rendering of text, inline objects, and decorations such as underlines.
    /// </summary>
    [Guid("553a9ff3-5693-4df7-b52b-74806f7f2eb9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextAnalyzer2
    {
        [PreserveSig]
        HRESULT GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, bool isSideways, float originX, float originY, /* _Out_ */ out DWRITE_MATRIX transform);
        
        [PreserveSig]
        HRESULT GetTypographicFeatures(ref IDWriteFontFace fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* optional(WCHAR) */ IntPtr localeName, uint maxTagCount, /* _Out_ */ out uint actualTagCount, /* _Out_writes_(maxTagCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] DWRITE_FONT_FEATURE_TAG[] tags);
        
        [PreserveSig]
        HRESULT CheckTypographicFeature(ref IDWriteFontFace fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* optional(WCHAR) */ IntPtr localeName, DWRITE_FONT_FEATURE_TAG featureTag, uint glyphCount, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] ushort[] glyphIndices, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] byte[] featureApplies);
    }
}
