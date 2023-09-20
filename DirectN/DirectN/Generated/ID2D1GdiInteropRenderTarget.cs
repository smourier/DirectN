// generated from <Windows SDK Path>\um\d2d1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Provides access to an device context that can accept GDI drawing commands.
    /// </summary>
    [ComImport, Guid("e0db51c3-6f77-4bae-b3d5-e47509b35838"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GdiInteropRenderTarget
    {
        [PreserveSig]
        HRESULT GetDC(D2D1_DC_INITIALIZE_MODE mode, /* _Out_ */ out IntPtr hdc);
        
        [PreserveSig]
        HRESULT ReleaseDC(/* optional(tagRECT) */ IntPtr update);
    }
}
