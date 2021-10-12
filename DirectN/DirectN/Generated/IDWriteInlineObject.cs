// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(3506,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteInlineObject interface wraps an application defined inline graphic, allowing DWrite to query metrics as if it was a glyph inline with the text.
    /// </summary>
    [ComImport, Guid("8339fde3-106f-47ab-8373-1c6295eb10b3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteInlineObject
    {
        [PreserveSig]
        HRESULT Draw(/* optional(void) */ IntPtr clientDrawingContext, /* _In_ */ IDWriteTextRenderer renderer, float originX, float originY, bool isSideways, bool isRightToLeft, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        HRESULT GetMetrics(/* _Out_ */ out DWRITE_INLINE_OBJECT_METRICS metrics);
        
        [PreserveSig]
        HRESULT GetOverhangMetrics(/* _Out_ */ out DWRITE_OVERHANG_METRICS overhangs);
        
        [PreserveSig]
        HRESULT GetBreakConditions(/* _Out_ */ out DWRITE_BREAK_CONDITION breakConditionBefore, /* _Out_ */ out DWRITE_BREAK_CONDITION breakConditionAfter);
    }
}
