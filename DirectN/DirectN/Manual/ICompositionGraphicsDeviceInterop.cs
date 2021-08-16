using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("A116FF71-F8BF-4C8A-9C98-70779A32A9C8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICompositionGraphicsDeviceInterop
    {
        [PreserveSig]
        HRESULT GetRenderingDevice([MarshalAs(UnmanagedType.IUnknown)] out object value);

        [PreserveSig]
        HRESULT SetRenderingDevice([MarshalAs(UnmanagedType.IUnknown)] object value);
    }
}
