using System;
using System.Runtime.InteropServices;
using HDC = System.IntPtr;

namespace DirectN
{
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
