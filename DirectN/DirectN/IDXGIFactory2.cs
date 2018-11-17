using System;
using System.Runtime.InteropServices;
using LUID = System.Int64;

namespace DirectN
{
    // dxgi1_2.h
    [Guid("50c83a1c-e072-4c48-87b0-3630fa36a6d0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIFactory2 : IDXGIFactory1
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

        // IDXGIFactory
        [PreserveSig]
        new HRESULT EnumAdapters(int Adapter, out IDXGIAdapter ppAdapter);

        [PreserveSig]
        new HRESULT MakeWindowAssociation(IntPtr WindowHandle, DXGI_MWA_FLAGS Flags);

        [PreserveSig]
        new HRESULT GetWindowAssociation(out IntPtr pWindowHandle);

        [PreserveSig]
        new HRESULT CreateSwapChain([MarshalAs(UnmanagedType.IUnknown)] object pDevice, ref DXGI_SWAP_CHAIN_DESC pDesc, out IDXGISwapChain ppSwapChain);

        [PreserveSig]
        new HRESULT CreateSoftwareAdapter(IntPtr Module, out IDXGIAdapter ppAdapter);

        // IDXGIFactory1
        [PreserveSig]
        new HRESULT EnumAdapters1(int Adapter, out IDXGIAdapter1 ppAdapter);

        [PreserveSig]
        new bool IsCurrent();

        // IDXGIFactory2
        [PreserveSig]
        bool IsWindowedStereoEnabled();

        [PreserveSig]
        HRESULT CreateSwapChainForHwnd(
            [MarshalAs(UnmanagedType.IUnknown)] object pDevice,
            IntPtr hWnd,
            ref DXGI_SWAP_CHAIN_DESC1 pDesc,
            ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pFullscreenDesc,
            IDXGIOutput pRestrictToOutput,
            out IDXGISwapChain1 ppSwapChain);

        [PreserveSig]
        HRESULT CreateSwapChainForCoreWindow(
            [MarshalAs(UnmanagedType.IUnknown)] object pDevice,
            [MarshalAs(UnmanagedType.IUnknown)] object pWindow,
            ref DXGI_SWAP_CHAIN_DESC1 pDesc,
            IDXGIOutput pRestrictToOutput,
            out IDXGISwapChain1 ppSwapChain);

        [PreserveSig]
        HRESULT GetSharedResourceAdapterLuid(IntPtr hResource, out LUID pLuid);

        [PreserveSig]
        HRESULT RegisterStereoStatusWindow(IntPtr WindowHandle, int wMsg, out int pdwCookie);

        [PreserveSig]
        HRESULT RegisterStereoStatusEvent(IntPtr hEvent, out int pdwCookie);

        [PreserveSig]
        HRESULT UnregisterStereoStatus(int dwCookie);

        [PreserveSig]
        HRESULT RegisterOcclusionStatusWindow(IntPtr WindowHandle, int wMsg, out int pdwCookie);

        [PreserveSig]
        HRESULT RegisterOcclusionStatusEvent(IntPtr hEvent, out int pdwCookie);

        [PreserveSig]
        void UnregisterOcclusionStatus(int dwCookie);

        [PreserveSig]
        HRESULT CreateSwapChainForComposition([MarshalAs(UnmanagedType.IUnknown)] object pDevice, ref DXGI_SWAP_CHAIN_DESC1 pDesc, IDXGIOutput pRestrictToOutput, out IDXGISwapChain1 ppSwapChain);
    }
}
