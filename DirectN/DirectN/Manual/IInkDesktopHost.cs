using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4ce7d875-a981-4140-a1ff-ad93258e8d59"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInkDesktopHost
    {
        [PreserveSig]
        HRESULT QueueWorkItem(IInkHostWorkItem workItem);

        [PreserveSig]
        HRESULT CreateInkPresenter([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppv);

        [PreserveSig]
        HRESULT CreateAndInitializeInkPresenter([MarshalAs(UnmanagedType.IUnknown)] object rootVisual, float width, float height, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
    }
}
