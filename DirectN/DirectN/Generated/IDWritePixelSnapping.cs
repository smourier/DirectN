// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(3582,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWritePixelSnapping interface defines the pixel snapping properties of a text renderer.
    /// </summary>
    [ComImport, Guid("eaf3a2da-ecf4-4d24-b644-b34f6842024b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWritePixelSnapping
    {
        [PreserveSig]
        HRESULT IsPixelSnappingDisabled(/* optional(void) */ IntPtr clientDrawingContext, /* _Out_ */ out bool isDisabled);
        
        [PreserveSig]
        HRESULT GetCurrentTransform(/* optional(void) */ IntPtr clientDrawingContext, /* _Out_ */ out DWRITE_MATRIX transform);
        
        [PreserveSig]
        HRESULT GetPixelsPerDip(/* optional(void) */ IntPtr clientDrawingContext, /* _Out_ */ out float pixelsPerDip);
    }
}
