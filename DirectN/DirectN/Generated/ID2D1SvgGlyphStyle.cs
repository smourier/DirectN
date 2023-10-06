// generated from <Windows SDK Path>\um\d2d1_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("af671749-d241-4db8-8e41-dcc2e5c1a438"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SvgGlyphStyle : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1SvgGlyphStyle
        [PreserveSig]
        HRESULT SetFill(/* _In_opt_ */ ID2D1Brush brush);
        
        [PreserveSig]
        void GetFill(/* _Outptr_result_maybenull_ */ out ID2D1Brush brush);
        
        [PreserveSig]
        HRESULT SetStroke(/* _In_opt_ */ ID2D1Brush brush, float strokeWidth, /* _In_reads_opt_(dashesCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] float[] dashes, int dashesCount, float dashOffset);
        
        [PreserveSig]
        uint GetStrokeDashesCount();
        
        [PreserveSig]
        void GetStroke(/* _Outptr_opt_result_maybenull_ */ out ID2D1Brush brush, /* optional(FLOAT) */ IntPtr strokeWidth, /* _Out_writes_opt_(dashesCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] float[] dashes, int dashesCount, /* optional(FLOAT) */ IntPtr dashOffset);
    }
}
