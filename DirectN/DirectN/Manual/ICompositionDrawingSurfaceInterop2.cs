using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("41E64AAE-98C0-4239-8E95-A330DD6AA18B"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICompositionDrawingSurfaceInterop2 : ICompositionDrawingSurfaceInterop
    {
        // ICompositionDrawingSurfaceInterop
        [PreserveSig]
        new HRESULT BeginDraw(IntPtr updateRect, [MarshalAs(UnmanagedType.LPStruct)] Guid iid, [MarshalAs(UnmanagedType.IUnknown)] out object updateObject, out tagPOINT updateOffset);

        [PreserveSig]
        new HRESULT EndDraw();

        [PreserveSig]
        new HRESULT Resize(tagSIZE sizePixels);

        [PreserveSig]
        new HRESULT Scroll(IntPtr scrollRect, IntPtr clipRect, int offsetX, int offsetY);

        [PreserveSig]
        new HRESULT ResumeDraw();

        [PreserveSig]
        new HRESULT SuspendDraw();

        // ICompositionDrawingSurfaceInterop2
        [PreserveSig]
        HRESULT CopySurface(IntPtr destinationResource, int destinationOffsetX, int destinationOffsetY, IntPtr sourceRectangle);
    }
}
