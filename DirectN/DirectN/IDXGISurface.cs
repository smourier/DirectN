using System;
using System.Runtime.InteropServices;
using HDC = System.IntPtr;

namespace DirectN
{
    [Guid("cafcb56c-6ac3-4889-bf47-9e23bbd260ec"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISurface : IDXGIDeviceSubObject
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

        // IDXGISurface
        [PreserveSig]
        HRESULT GetDesc(out DXGI_SURFACE_DESC pDesc);

        [PreserveSig]
        HRESULT Map(out DXGI_MAPPED_RECT pLockedRect, DXGI_MAP_FLAGS MapFlags);

        [PreserveSig]
        HRESULT Unmap();
    }

    [Guid("4AE63092-6327-4c1b-80AE-BFE12EA32B86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISurface1 : IDXGISurface
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

        // IDXGISurface
        [PreserveSig]
        new HRESULT GetDesc(out DXGI_SURFACE_DESC pDesc);

        [PreserveSig]
        new HRESULT Map(out DXGI_MAPPED_RECT pLockedRect, DXGI_MAP_FLAGS MapFlags);

        [PreserveSig]
        new HRESULT Unmap();

        // IDXGISurface1
        [PreserveSig]
        HRESULT GetDC(bool Discard, out HDC phdc);

        [PreserveSig]
        HRESULT ReleaseDC(ref RECT pDirtyRect);
    }

    [Guid("aba496dd-b617-4cb8-a866-bc44d7eb1fa2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISurface2 : IDXGISurface1
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

        // IDXGISurface
        [PreserveSig]
        new HRESULT GetDesc(out DXGI_SURFACE_DESC pDesc);

        [PreserveSig]
        new HRESULT Map(out DXGI_MAPPED_RECT pLockedRect, DXGI_MAP_FLAGS MapFlags);

        [PreserveSig]
        new HRESULT Unmap();

        // IDXGISurface1
        [PreserveSig]
        new HRESULT GetDC(bool Discard, out HDC phdc);

        [PreserveSig]
        new HRESULT ReleaseDC(ref RECT pDirtyRect);

        // IDXGISurface2
        HRESULT GetResource([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppParentResource, out int pSubresourceIndex);
    }
}
