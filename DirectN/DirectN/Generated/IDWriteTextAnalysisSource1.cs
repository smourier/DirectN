// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_1.h(1721,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface implemented by the client to provide needed information to the text analyzer, such as the text and associated text properties. If any of these callbacks returns an error, the analysis functions will stop prematurely and return a callback error.
    /// </summary>
    [ComImport, Guid("639cfad8-0fb4-4b21-a58a-067920120009"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextAnalysisSource1 : IDWriteTextAnalysisSource
    {
        // IDWriteTextAnalysisSource
        [PreserveSig]
        new HRESULT GetTextAtPosition(uint textPosition, /* _Outptr_result_buffer_(*textLength) */ out IntPtr textString, /* _Out_ */ out uint textLength);
        
        [PreserveSig]
        new HRESULT GetTextBeforePosition(uint textPosition, /* _Outptr_result_buffer_(*textLength) */ out IntPtr textString, /* _Out_ */ out uint textLength);
        
        [PreserveSig]
        new DWRITE_READING_DIRECTION GetParagraphReadingDirection();
        
        [PreserveSig]
        new HRESULT GetLocaleName(uint textPosition, /* _Out_ */ out uint textLength, /* _Outptr_result_z_ */ out IntPtr localeName);
        
        [PreserveSig]
        new HRESULT GetNumberSubstitution(uint textPosition, /* _Out_ */ out uint textLength, /* _COM_Outptr_ */ out IDWriteNumberSubstitution numberSubstitution);
        
        // IDWriteTextAnalysisSource1
        [PreserveSig]
        HRESULT GetVerticalGlyphOrientation(uint textPosition, /* _Out_ */ out uint textLength, /* _Out_ */ out DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation, /* _Out_ */ out byte bidiLevel);
    }
}
