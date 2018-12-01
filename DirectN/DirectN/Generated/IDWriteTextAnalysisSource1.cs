// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_1.h(1721,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface implemented by the client to provide needed information to the text analyzer, such as the text and associated text properties. If any of these callbacks returns an error, the analysis functions will stop prematurely and return a callback error.
    /// </summary>
    [Guid("639cfad8-0fb4-4b21-a58a-067920120009"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextAnalysisSource1
    {
        [PreserveSig]
        HRESULT GetVerticalGlyphOrientation(uint textPosition, /* _Out_ */ out uint textLength, /* _Out_ */ out DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation, /* _Out_ */ out byte bidiLevel);
    }
}
