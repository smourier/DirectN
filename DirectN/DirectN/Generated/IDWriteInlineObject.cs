using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8339FDE3-106F-47ab-8373-1C6295EB10B3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDWriteInlineObject
    {
        [PreserveSig]
        HRESULT Draw(
            IntPtr clientDrawingContext,
            IDWriteTextRenderer renderer,
            float originX,
            float originY,
            bool isSideways,
            bool isRightToLeft,
            [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect
        );

        [PreserveSig]
        HRESULT GetMetrics(out DWRITE_INLINE_OBJECT_METRICS metrics);

        [PreserveSig]
        HRESULT GetOverhangMetrics(out DWRITE_OVERHANG_METRICS overhangs);

        [PreserveSig]
        HRESULT GetBreakConditions(out DWRITE_BREAK_CONDITION breakConditionBefore, out DWRITE_BREAK_CONDITION breakConditionAfter);
    }
}
