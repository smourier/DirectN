using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("73f3c0d9-2e8b-48f3-895e-20cbd27b723b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInkPresenterDesktop
    {
        [PreserveSig]
        HRESULT SetRootVisual([MarshalAs(UnmanagedType.IUnknown)] object rootVisual, [MarshalAs(UnmanagedType.IUnknown)] object device);

        [PreserveSig]
        HRESULT SetCommitRequestHandler(IInkCommitRequestHandler handler);

        [PreserveSig]
        HRESULT GetSize(out float width, out float height);

        [PreserveSig]
        HRESULT SetSize(float width, float height);

        [PreserveSig]
        HRESULT OnHighContrastChanged();
    }
}
