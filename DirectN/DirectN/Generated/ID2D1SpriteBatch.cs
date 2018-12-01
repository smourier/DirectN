// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1087,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4dc583bf-3a10-438a-8722-e9765224f1f1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SpriteBatch
    {
        [PreserveSig]
        HRESULT AddSprites(uint spriteCount, /* _In_reads_bytes_(sizeof(D2D1_RECT_F) + (spriteCount - 1) * destinationRectanglesStride) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] D2D_RECT_F[] destinationRectangles, /* _In_reads_bytes_opt_(sizeof(D2D1_RECT_U) + (spriteCount - 1) * sourceRectanglesStride) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] D2D_RECT_U[] sourceRectangles, /* _In_reads_bytes_opt_(sizeof(D2D1_COLOR_F) + (spriteCount - 1) * colorsStride) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] _D3DCOLORVALUE[] colors, /* _In_reads_bytes_opt_(sizeof(D2D1_MATRIX_3X2_F) + (spriteCount - 1) * transformsStride) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] D2D_MATRIX_3X2_F[] transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride);
        
        [PreserveSig]
        HRESULT SetSprites(uint startIndex, uint spriteCount, /* _In_reads_bytes_opt_(sizeof(D2D1_RECT_F) + (spriteCount - 1) * destinationRectanglesStride) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] D2D_RECT_F[] destinationRectangles, /* _In_reads_bytes_opt_(sizeof(D2D1_RECT_U) + (spriteCount - 1) * sourceRectanglesStride) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] D2D_RECT_U[] sourceRectangles, /* _In_reads_bytes_opt_(sizeof(D2D1_COLOR_F) + (spriteCount - 1) * colorsStride) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] _D3DCOLORVALUE[] colors, /* _In_reads_bytes_opt_(sizeof(D2D1_MATRIX_3X2_F) + (spriteCount - 1) * transformsStride) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] D2D_MATRIX_3X2_F[] transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride);
        
        [PreserveSig]
        HRESULT GetSprites(uint startIndex, uint spriteCount, /* _Out_writes_opt_(spriteCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D_RECT_F[] destinationRectangles, /* _Out_writes_opt_(spriteCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D_RECT_U[] sourceRectangles, /* _Out_writes_opt_(spriteCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _D3DCOLORVALUE[] colors, /* _Out_writes_opt_(spriteCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D_MATRIX_3X2_F[] transforms);
        
        [PreserveSig]
        uint GetSpriteCount();
        
        [PreserveSig]
        void Clear();
    }
}
