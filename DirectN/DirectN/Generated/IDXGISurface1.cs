// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi.h(1072,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4ae63092-6327-4c1b-80ae-bfe12ea32b86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGISurface1 : IDXGISurface
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [in] */ uint DataSize, /* [annotation][in] _In_reads_bytes_(DataSize) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [annotation][out][in] _Inout_ */ ref uint pDataSize, /* [annotation][out] _Out_writes_bytes_(*pDataSize) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT GetParent(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][retval][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);
        
        // IDXGIDeviceSubObject
        [PreserveSig]
        new HRESULT GetDevice(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][retval][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppDevice);
        
        // IDXGISurface
        [PreserveSig]
        new HRESULT GetDesc(/* [annotation][out] _Out_ */ out DXGI_SURFACE_DESC pDesc);
        
        [PreserveSig]
        new HRESULT Map(/* [annotation][out] _Out_ */ out DXGI_MAPPED_RECT pLockedRect, /* [in] */ uint MapFlags);
        
        [PreserveSig]
        new HRESULT Unmap();
        
        // IDXGISurface1
        [PreserveSig]
        HRESULT GetDC(/* [in] */ bool Discard, /* [annotation][out] _Out_ */ out IntPtr phdc);
        
        [PreserveSig]
        HRESULT ReleaseDC(/* [annotation][in] _In_opt_ */ ref tagRECT pDirtyRect);
    }
}
