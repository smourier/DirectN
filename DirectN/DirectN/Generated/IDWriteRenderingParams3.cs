// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(345,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface that represents text rendering settings for glyph rasterization and filtering.
    /// </summary>
    [Guid("b7924baa-391b-412a-8c5c-e44cc2d867dc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteRenderingParams3
    {
        [PreserveSig]
        DWRITE_RENDERING_MODE1 GetRenderingMode1();
    }
}
