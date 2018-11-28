using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("eaf3a2da-ecf4-4d24-b644-b34f6842024b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDWritePixelSnapping
    {
        [PreserveSig]
        HRESULT IsPixelSnappingDisabled(IntPtr clientDrawingContext, out bool isDisabled);

        [PreserveSig]
        HRESULT GetCurrentTransform(IntPtr clientDrawingContext, out DWRITE_MATRIX transform);

        [PreserveSig]
        HRESULT GetPixelsPerDip(IntPtr clientDrawingContext, out float pixelsPerDip);
    }
}
