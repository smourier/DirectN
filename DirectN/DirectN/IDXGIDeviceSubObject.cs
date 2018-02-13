using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3d3e0379-f9de-4d58-bb6c-18d62992f1a6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIDeviceSubObject
    {
        // IDXGIObject
        [PreserveSig]
        int GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDevice);
    }
}
