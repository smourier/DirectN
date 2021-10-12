// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dxgi1_2.h(1687,5)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [ComImport, Guid("50c83a1c-e072-4c48-87b0-3630fa36a6d0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIFactory2 : IDXGIFactory1
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
        new HRESULT EnumAdapters1(/* [in] */ uint Adapter, /* [annotation][out] _COM_Outptr_ */ out IDXGIAdapter1 ppAdapter);
        
        [PreserveSig]
        new bool IsCurrent();
        
        // IDXGIFactory2
        [PreserveSig]
        bool IsWindowedStereoEnabled();
        
        [PreserveSig]
        HRESULT CreateSwapChainForHwnd(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, /* [annotation][in] _In_ */ IntPtr hWnd, /* [annotation][in] _In_ */ ref DXGI_SWAP_CHAIN_DESC1 pDesc, /* optional(DXGI_SWAP_CHAIN_FULLSCREEN_DESC) */ IntPtr pFullscreenDesc, /* [annotation][in] _In_opt_ */ IDXGIOutput pRestrictToOutput, /* [annotation][out] _COM_Outptr_ */ out IDXGISwapChain1 ppSwapChain);
        
        [PreserveSig]
        HRESULT CreateSwapChainForCoreWindow(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pWindow, /* [annotation][in] _In_ */ ref DXGI_SWAP_CHAIN_DESC1 pDesc, /* [annotation][in] _In_opt_ */ IDXGIOutput pRestrictToOutput, /* [annotation][out] _COM_Outptr_ */ out IDXGISwapChain1 ppSwapChain);
        
        [PreserveSig]
        HRESULT GetSharedResourceAdapterLuid(/* [annotation] _In_ */ IntPtr hResource, /* [annotation] _Out_ */ out LUID pLuid);
        
        [PreserveSig]
        HRESULT RegisterStereoStatusWindow(/* [annotation][in] _In_ */ IntPtr WindowHandle, /* [annotation][in] _In_ */ uint wMsg, /* [annotation][out] _Out_ */ out uint pdwCookie);
        
        [PreserveSig]
        HRESULT RegisterStereoStatusEvent(/* [annotation][in] _In_ */ IntPtr hEvent, /* [annotation][out] _Out_ */ out uint pdwCookie);
        
        [PreserveSig]
        void UnregisterStereoStatus(/* [annotation][in] _In_ */ uint dwCookie);
        
        [PreserveSig]
        HRESULT RegisterOcclusionStatusWindow(/* [annotation][in] _In_ */ IntPtr WindowHandle, /* [annotation][in] _In_ */ uint wMsg, /* [annotation][out] _Out_ */ out uint pdwCookie);
        
        [PreserveSig]
        HRESULT RegisterOcclusionStatusEvent(/* [annotation][in] _In_ */ IntPtr hEvent, /* [annotation][out] _Out_ */ out uint pdwCookie);
        
        [PreserveSig]
        void UnregisterOcclusionStatus(/* [annotation][in] _In_ */ uint dwCookie);
        
        [PreserveSig]
        HRESULT CreateSwapChainForComposition(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, /* [annotation][in] _In_ */ ref DXGI_SWAP_CHAIN_DESC1 pDesc, /* [annotation][in] _In_opt_ */ IDXGIOutput pRestrictToOutput, /* [annotation][out] _COM_Outptr_ */ out IDXGISwapChain1 ppSwapChain);
    }
}
