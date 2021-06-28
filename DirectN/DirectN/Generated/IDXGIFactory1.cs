// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgi.h(2413,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("770aae78-f26f-4dba-a829-253c83d1b387"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIFactory1 : IDXGIFactory
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
        
        // IDXGIFactory
        [PreserveSig]
        new HRESULT EnumAdapters(/* [in] */ uint Adapter, /* [annotation][out] _COM_Outptr_ */ out IDXGIAdapter ppAdapter);
        
        [PreserveSig]
        new HRESULT MakeWindowAssociation(IntPtr WindowHandle, uint Flags);
        
        [PreserveSig]
        new HRESULT GetWindowAssociation(/* [annotation][out] _Out_ */ out IntPtr pWindowHandle);
        
        [PreserveSig]
        new HRESULT CreateSwapChain(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, /* [annotation][in] _In_ */ ref DXGI_SWAP_CHAIN_DESC pDesc, /* [annotation][out] _COM_Outptr_ */ out IDXGISwapChain ppSwapChain);
        
        [PreserveSig]
        new HRESULT CreateSoftwareAdapter(/* [in] */ IntPtr Module, /* [annotation][out] _COM_Outptr_ */ out IDXGIAdapter ppAdapter);
        
        // IDXGIFactory1
        [PreserveSig]
        HRESULT EnumAdapters1(/* [in] */ uint Adapter, /* [annotation][out] _COM_Outptr_ */ out IDXGIAdapter1 ppAdapter);
        
        [PreserveSig]
        bool IsCurrent();
    }
}
