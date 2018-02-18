using System;
using System.Runtime.InteropServices;
using LUID = System.Int64;

namespace DirectN
{
    [Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIFactory : IDXGIObject
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
        HRESULT EnumAdapters(int Adapter, out IDXGIAdapter ppAdapter);

        [PreserveSig]
        HRESULT MakeWindowAssociation(IntPtr WindowHandle, DXGI_MWA_FLAGS Flags);

        [PreserveSig]
        HRESULT GetWindowAssociation(out IntPtr pWindowHandle);

        [PreserveSig]
        HRESULT CreateSwapChain([MarshalAs(UnmanagedType.IUnknown)] object pDevice, ref DXGI_SWAP_CHAIN_DESC pDesc, out IDXGISwapChain ppSwapChain);

        [PreserveSig]
        HRESULT CreateSoftwareAdapter(IntPtr Module, out IDXGIAdapter ppAdapter);
    }

    [Guid("770aae78-f26f-4dba-a829-253c83d1b387"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIFactory1 : IDXGIFactory
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
        HRESULT EnumAdapters1(int Adapter, out IDXGIAdapter1 ppAdapter);

        [PreserveSig]
        bool IsCurrent();
    }

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

    // dxgi1_3.h
    [Guid("25483823-cd46-4c7d-86ca-47aa95b837bd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIFactory3 : IDXGIFactory2
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
        new bool IsWindowedStereoEnabled();

        [PreserveSig]
        new HRESULT CreateSwapChainForHwnd(
            [MarshalAs(UnmanagedType.IUnknown)] object pDevice,
            IntPtr hWnd,
            ref DXGI_SWAP_CHAIN_DESC1 pDesc,
            ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pFullscreenDesc,
            IDXGIOutput pRestrictToOutput,
            out IDXGISwapChain1 ppSwapChain);

        [PreserveSig]
        new HRESULT CreateSwapChainForCoreWindow(
            [MarshalAs(UnmanagedType.IUnknown)] object pDevice,
            [MarshalAs(UnmanagedType.IUnknown)] object pWindow,
            ref DXGI_SWAP_CHAIN_DESC1 pDesc,
            IDXGIOutput pRestrictToOutput,
            out IDXGISwapChain1 ppSwapChain);

        [PreserveSig]
        new HRESULT GetSharedResourceAdapterLuid(IntPtr hResource, out LUID pLuid);

        [PreserveSig]
        new HRESULT RegisterStereoStatusWindow(IntPtr WindowHandle, int wMsg, out int pdwCookie);

        [PreserveSig]
        new HRESULT RegisterStereoStatusEvent(IntPtr hEvent, out int pdwCookie);

        [PreserveSig]
        new HRESULT UnregisterStereoStatus(int dwCookie);

        [PreserveSig]
        new HRESULT RegisterOcclusionStatusWindow(IntPtr WindowHandle, int wMsg, out int pdwCookie);

        [PreserveSig]
        new HRESULT RegisterOcclusionStatusEvent(IntPtr hEvent, out int pdwCookie);

        [PreserveSig]
        new void UnregisterOcclusionStatus(int dwCookie);

        [PreserveSig]
        new HRESULT CreateSwapChainForComposition([MarshalAs(UnmanagedType.IUnknown)] object pDevice, ref DXGI_SWAP_CHAIN_DESC1 pDesc, IDXGIOutput pRestrictToOutput, out IDXGISwapChain1 ppSwapChain);

        // IDXGIFactory3
        [PreserveSig]
        DXGI_CREATE_FACTORY_FLAGS GetCreationFlags();
    }

    // dxgi1_4.h
    [Guid("1bc6ea02-ef36-464f-bf0c-21ca39e5168a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIFactory4 : IDXGIFactory3
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
        new bool IsWindowedStereoEnabled();

        [PreserveSig]
        new HRESULT CreateSwapChainForHwnd(
            [MarshalAs(UnmanagedType.IUnknown)] object pDevice,
            IntPtr hWnd,
            ref DXGI_SWAP_CHAIN_DESC1 pDesc,
            ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pFullscreenDesc,
            IDXGIOutput pRestrictToOutput,
            out IDXGISwapChain1 ppSwapChain);

        [PreserveSig]
        new HRESULT CreateSwapChainForCoreWindow(
            [MarshalAs(UnmanagedType.IUnknown)] object pDevice,
            [MarshalAs(UnmanagedType.IUnknown)] object pWindow,
            ref DXGI_SWAP_CHAIN_DESC1 pDesc,
            IDXGIOutput pRestrictToOutput,
            out IDXGISwapChain1 ppSwapChain);

        [PreserveSig]
        new HRESULT GetSharedResourceAdapterLuid(IntPtr hResource, out LUID pLuid);

        [PreserveSig]
        new HRESULT RegisterStereoStatusWindow(IntPtr WindowHandle, int wMsg, out int pdwCookie);

        [PreserveSig]
        new HRESULT RegisterStereoStatusEvent(IntPtr hEvent, out int pdwCookie);

        [PreserveSig]
        new HRESULT UnregisterStereoStatus(int dwCookie);

        [PreserveSig]
        new HRESULT RegisterOcclusionStatusWindow(IntPtr WindowHandle, int wMsg, out int pdwCookie);

        [PreserveSig]
        new HRESULT RegisterOcclusionStatusEvent(IntPtr hEvent, out int pdwCookie);

        [PreserveSig]
        new void UnregisterOcclusionStatus(int dwCookie);

        [PreserveSig]
        new HRESULT CreateSwapChainForComposition([MarshalAs(UnmanagedType.IUnknown)] object pDevice, ref DXGI_SWAP_CHAIN_DESC1 pDesc, IDXGIOutput pRestrictToOutput, out IDXGISwapChain1 ppSwapChain);

        // IDXGIFactory3
        [PreserveSig]
        new DXGI_CREATE_FACTORY_FLAGS GetCreationFlags();

        // IDXGIFactory4
        [PreserveSig]
        HRESULT EnumAdapterByLuid(LUID AdapterLuid, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapter);

        [PreserveSig]
        HRESULT EnumWarpAdapter([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapter);
    }

    // dxgi1_5.h
    [Guid("7632e1f5-ee65-4dca-87fd-84cd75f8838d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIFactory5 : IDXGIFactory4
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
        new bool IsWindowedStereoEnabled();

        [PreserveSig]
        new HRESULT CreateSwapChainForHwnd(
            [MarshalAs(UnmanagedType.IUnknown)] object pDevice,
            IntPtr hWnd,
            ref DXGI_SWAP_CHAIN_DESC1 pDesc,
            ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pFullscreenDesc,
            IDXGIOutput pRestrictToOutput,
            out IDXGISwapChain1 ppSwapChain);

        [PreserveSig]
        new HRESULT CreateSwapChainForCoreWindow(
            [MarshalAs(UnmanagedType.IUnknown)] object pDevice,
            [MarshalAs(UnmanagedType.IUnknown)] object pWindow,
            ref DXGI_SWAP_CHAIN_DESC1 pDesc,
            IDXGIOutput pRestrictToOutput,
            out IDXGISwapChain1 ppSwapChain);

        [PreserveSig]
        new HRESULT GetSharedResourceAdapterLuid(IntPtr hResource, out LUID pLuid);

        [PreserveSig]
        new HRESULT RegisterStereoStatusWindow(IntPtr WindowHandle, int wMsg, out int pdwCookie);

        [PreserveSig]
        new HRESULT RegisterStereoStatusEvent(IntPtr hEvent, out int pdwCookie);

        [PreserveSig]
        new HRESULT UnregisterStereoStatus(int dwCookie);

        [PreserveSig]
        new HRESULT RegisterOcclusionStatusWindow(IntPtr WindowHandle, int wMsg, out int pdwCookie);

        [PreserveSig]
        new HRESULT RegisterOcclusionStatusEvent(IntPtr hEvent, out int pdwCookie);

        [PreserveSig]
        new void UnregisterOcclusionStatus(int dwCookie);

        [PreserveSig]
        new HRESULT CreateSwapChainForComposition([MarshalAs(UnmanagedType.IUnknown)] object pDevice, ref DXGI_SWAP_CHAIN_DESC1 pDesc, IDXGIOutput pRestrictToOutput, out IDXGISwapChain1 ppSwapChain);

        // IDXGIFactory3
        [PreserveSig]
        new DXGI_CREATE_FACTORY_FLAGS GetCreationFlags();

        // IDXGIFactory4
        [PreserveSig]
        new HRESULT EnumAdapterByLuid(LUID AdapterLuid, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapter);

        [PreserveSig]
        new HRESULT EnumWarpAdapter([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapter);

        // IDXGIFactory5
        HRESULT CheckFeatureSupport(DXGI_FEATURE Feature, IntPtr pFeatureSupportData, int FeatureSupportDataSize);
    }
}
