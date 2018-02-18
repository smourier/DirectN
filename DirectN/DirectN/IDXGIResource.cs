using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("035f3ab4-482e-4e50-b41f-8a7f8bd8960b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIResource : IDXGIDeviceSubObject
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, int DataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT SetPrivateDataInterface([MarshalAs(UnmanagedType.LPStruct)] Guid Name, [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

        [PreserveSig]
        new HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, out int pDataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT GetParent([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);

        // IDXGIDeviceSubObject
        [PreserveSig]
        new int GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDevice);

        // IDXGIResource
        [PreserveSig]
        HRESULT GetSharedHandle(out IntPtr pSharedHandle);

        [PreserveSig]
        HRESULT GetUsage(out DXGI_USAGE pUsage);

        [PreserveSig]
        HRESULT SetEvictionPriority(int EvictionPriority);

        [PreserveSig]
        HRESULT GetEvictionPriority(out int pEvictionPriority);
    }

    [Guid("30961379-4609-4a41-998e-54fe567ee0c1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIResource1 : IDXGIResource
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, int DataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT SetPrivateDataInterface([MarshalAs(UnmanagedType.LPStruct)] Guid Name, [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

        [PreserveSig]
        new HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, out int pDataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT GetParent([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);

        // IDXGIDeviceSubObject
        [PreserveSig]
        new int GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDevice);

        // IDXGIResource
        [PreserveSig]
        new HRESULT GetSharedHandle(out IntPtr pSharedHandle);

        [PreserveSig]
        new HRESULT GetUsage(out DXGI_USAGE pUsage);

        [PreserveSig]
        new HRESULT SetEvictionPriority(int EvictionPriority);

        [PreserveSig]
        new HRESULT GetEvictionPriority(out int pEvictionPriority);

        // IDXGIResource1
        [PreserveSig]
        HRESULT CreateSubresourceSurface(int index, out IDXGISurface2 ppSurface);

        [PreserveSig]
        HRESULT CreateSharedHandle(IntPtr pAttributes, int dwAccess, [MarshalAs(UnmanagedType.LPWStr)] string lpName, out IntPtr pHandle);
    }
}
