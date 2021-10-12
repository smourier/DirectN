// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dxgi.h(2750,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("29038f61-3839-4626-91fd-086879011a05"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIAdapter1 : IDXGIAdapter
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
        
        // IDXGIAdapter
        [PreserveSig]
        new HRESULT EnumOutputs(/* [in] */ uint Output, /* [annotation][out][in] _COM_Outptr_ */ out IDXGIOutput ppOutput);
        
        [PreserveSig]
        new HRESULT GetDesc(/* [annotation][out] _Out_ */ out DXGI_ADAPTER_DESC pDesc);
        
        [PreserveSig]
        new HRESULT CheckInterfaceSupport(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid InterfaceName, /* [annotation][out] _Out_ */ out long pUMDVersion);
        
        // IDXGIAdapter1
        [PreserveSig]
        HRESULT GetDesc1(/* [annotation][out] _Out_ */ out DXGI_ADAPTER_DESC1 pDesc);
    }
}
