// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1250,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This object supplies the values for context-fill, context-stroke, and context-value that are used when rendering SVG glyphs.
    /// </summary>
    [Guid("af671749-d241-4db8-8e41-dcc2e5c1a438"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SvgGlyphStyle
    {
        [PreserveSig]
        HRESULT SetFill(/* optional(ID2D1Brush) */ IntPtr brush);
        
        [PreserveSig]
        void GetFill(/* _Outptr_result_maybenull_ */ out IntPtr brush);
        
        [PreserveSig]
        HRESULT SetStroke(/* optional(ID2D1Brush) */ IntPtr brush, float strokeWidth, /* _In_reads_opt_(dashesCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] float[] dashes, uint dashesCount, float dashOffset);
        
        [PreserveSig]
        uint GetStrokeDashesCount();
        
        [PreserveSig]
        void GetStroke(/* optional(ID2D1Brush) */ out IntPtr brush, /* _Out_opt_ */ out float strokeWidth, /* _Out_writes_opt_(dashesCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] float[] dashes, uint dashesCount, /* _Out_opt_ */ out float dashOffset);
    }
}
