// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_1.h(1760,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface implemented by the client to receive the output of the text analyzers.
    /// </summary>
    [Guid("b0d941a0-85e7-4d8b-9fd3-5ced9934482a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextAnalysisSink1
    {
        [PreserveSig]
        HRESULT SetGlyphOrientation(uint textPosition, uint textLength, DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, byte adjustedBidiLevel, bool isSideways, bool isRightToLeft);
    }
}
