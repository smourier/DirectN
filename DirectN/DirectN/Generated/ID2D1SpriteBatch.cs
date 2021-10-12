// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(1087,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4dc583bf-3a10-438a-8722-e9765224f1f1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SpriteBatch : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1SpriteBatch
        [PreserveSig]
        HRESULT AddSprites(uint spriteCount, /* _In_reads_bytes_(sizeof(D2D1_RECT_F) + (spriteCount - 1) * destinationRectanglesStride) */ ref D2D_RECT_F destinationRectangles, /* optional(D2D_RECT_U) */ IntPtr sourceRectangles, /* optional(_D3DCOLORVALUE) */ IntPtr colors, /* optional(D2D_MATRIX_3X2_F) */ IntPtr transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride);
        
        [PreserveSig]
        HRESULT SetSprites(uint startIndex, uint spriteCount, /* optional(D2D_RECT_F) */ IntPtr destinationRectangles, /* optional(D2D_RECT_U) */ IntPtr sourceRectangles, /* optional(_D3DCOLORVALUE) */ IntPtr colors, /* optional(D2D_MATRIX_3X2_F) */ IntPtr transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride);
        
        [PreserveSig]
        HRESULT GetSprites(uint startIndex, int spriteCount, /* _Out_writes_opt_(spriteCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D_RECT_F[] destinationRectangles, /* _Out_writes_opt_(spriteCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D_RECT_U[] sourceRectangles, /* _Out_writes_opt_(spriteCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _D3DCOLORVALUE[] colors, /* _Out_writes_opt_(spriteCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D_MATRIX_3X2_F[] transforms);
        
        [PreserveSig]
        uint GetSpriteCount();
        
        [PreserveSig]
        void Clear();
    }
}
