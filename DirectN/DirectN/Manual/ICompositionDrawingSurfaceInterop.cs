using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("FD04E6E3-FE0C-4C3C-AB19-A07601A576EE"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICompositionDrawingSurfaceInterop
    {
        [PreserveSig]
        HRESULT BeginDraw(IntPtr updateRect, [MarshalAs(UnmanagedType.LPStruct)] Guid iid, [MarshalAs(UnmanagedType.IUnknown)] out object updateObject, out tagPOINT updateOffset);

        [PreserveSig]
        HRESULT EndDraw();

        [PreserveSig]
        HRESULT Resize(tagSIZE sizePixels);

        [PreserveSig]
        HRESULT Scroll(IntPtr scrollRect, IntPtr clipRect, int offsetX, int offsetY);

        [PreserveSig]
        HRESULT ResumeDraw();

        [PreserveSig]
        HRESULT SuspendDraw();
    }
}
