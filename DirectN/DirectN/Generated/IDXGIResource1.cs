// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_2.h(726,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("30961379-4609-4a41-998e-54fe567ee0c1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIResource1 : IDXGIResource
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
        
        // IDXGIResource
        [PreserveSig]
        new HRESULT GetSharedHandle(/* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object pSharedHandle);
        
        [PreserveSig]
        new HRESULT GetUsage(/* [out] */ out uint pUsage);
        
        [PreserveSig]
        new HRESULT SetEvictionPriority(/* [in] */ uint EvictionPriority);
        
        [PreserveSig]
        new HRESULT GetEvictionPriority(/* [annotation][retval][out] _Out_ */ out uint pEvictionPriority);
        
        // IDXGIResource1
        [PreserveSig]
        HRESULT CreateSubresourceSurface(uint index, /* [annotation][out] _COM_Outptr_ */ out IDXGISurface2 ppSurface);
        
        [PreserveSig]
        HRESULT CreateSharedHandle(/* [annotation][in] _In_opt_ */ ref _SECURITY_ATTRIBUTES pAttributes, /* [annotation][in] _In_ */ uint dwAccess, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpName, /* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object pHandle);
    }
}
