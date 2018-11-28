using System;
using System.Runtime.InteropServices;
using HDC = System.IntPtr;

namespace DirectN
{
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
}
