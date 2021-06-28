// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(2653,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface implemented by the text analyzer's client to receive the output of a given text analysis. The Text analyzer disregards any current state of the analysis sink, therefore a Set method call on a range overwrites the previously set analysis result of the same range.
    /// </summary>
    [ComImport, Guid("5810cd44-0ca0-4701-b3fa-bec5182ae4f6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextAnalysisSink
    {
        [PreserveSig]
        HRESULT SetScriptAnalysis(uint textPosition, uint textLength, /* _In_ */ ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis);
        
        [PreserveSig]
        HRESULT SetLineBreakpoints(uint textPosition, int textLength, /* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_LINE_BREAKPOINT[] lineBreakpoints);
        
        [PreserveSig]
        HRESULT SetBidiLevel(uint textPosition, uint textLength, byte explicitLevel, byte resolvedLevel);
        
        [PreserveSig]
        HRESULT SetNumberSubstitution(uint textPosition, uint textLength, /* _In_ */ IDWriteNumberSubstitution numberSubstitution);
    }
}
