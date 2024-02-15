using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("25297D5C-3AD4-4C9C-B5CF-E36A38512330"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICompositorInterop
    {
        [PreserveSig]
        HRESULT CreateCompositionSurfaceForHandle(IntPtr swapChain, out /*ICompositionSurface*/ IntPtr result);

        [PreserveSig]
        HRESULT CreateCompositionSurfaceForSwapChain([MarshalAs(UnmanagedType.IUnknown)] object swapChain, out /*ICompositionSurface*/ IntPtr result);

        [PreserveSig]
        HRESULT CreateGraphicsDevice([MarshalAs(UnmanagedType.IUnknown)] object renderingDevice, out IntPtr result);
    }
}
