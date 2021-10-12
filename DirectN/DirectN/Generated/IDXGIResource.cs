// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dxgi.h(606,5)
using System;
using System.Runtime.InteropServices;
using DXGI_USAGE = System.UInt32;

namespace DirectN
{
    [ComImport, Guid("035f3ab4-482e-4e50-b41f-8a7f8bd8960b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIResource : IDXGIDeviceSubObject
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [in] */ uint DataSize, /* [annotation][in] _In_reads_bytes_(DataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* optional(IUnknown) */ IntPtr pUnknown);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [annotation][out][in] _Inout_ */ ref uint pDataSize, /* [annotation][out] _Out_writes_bytes_(*pDataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT GetParent(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][retval][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);
        
        // IDXGIDeviceSubObject
        [PreserveSig]
        new HRESULT GetDevice(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][retval][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppDevice);
        
        // IDXGIResource
        [PreserveSig]
        HRESULT GetSharedHandle(/* [annotation][out] _Out_ */ out IntPtr pSharedHandle);
        
        [PreserveSig]
        HRESULT GetUsage(/* [out] */ out DXGI_USAGE pUsage);
        
        [PreserveSig]
        HRESULT SetEvictionPriority(/* [in] */ uint EvictionPriority);
        
        [PreserveSig]
        HRESULT GetEvictionPriority(/* [annotation][retval][out] _Out_ */ out uint pEvictionPriority);
    }
}
