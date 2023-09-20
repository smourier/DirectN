// generated from <Windows SDK Path>\um\d2d1effectauthor.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface implemented by a transform author to indicate that it should receive an analysis result callback.
    /// </summary>
    [ComImport, Guid("0359dc30-95e6-4568-9055-27720d130e93"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1AnalysisTransform
    {
        [PreserveSig]
        HRESULT ProcessAnalysisResults(/* _In_reads_(analysisDataCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] analysisData, int analysisDataCount);
    }
}
