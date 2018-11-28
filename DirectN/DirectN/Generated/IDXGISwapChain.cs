using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISwapChain : IDXGIDeviceSubObject
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

        // IDXGISwapChain
        [PreserveSig]
        HRESULT Present(int SyncInterval, DXGI_PRESENT Flags);

        [PreserveSig]
        HRESULT GetBuffer(int Buffer, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppSurface);

        [PreserveSig]
        HRESULT SetFullscreenState(bool Fullscreen, IDXGIOutput pTarget);

        [PreserveSig]
        HRESULT GetFullscreenState(out bool pFullscreen, out IDXGIOutput ppTarget);

        [PreserveSig]
        HRESULT GetDesc(out DXGI_SWAP_CHAIN_DESC pDesc);

        [PreserveSig]
        HRESULT ResizeBuffers(
            int BufferCount,
            int Width,
            int Height,
            DXGI_FORMAT NewFormat,
            DXGI_SWAP_CHAIN_FLAG SwapChainFlags);

        [PreserveSig]
        HRESULT ResizeTarget(ref DXGI_MODE_DESC pNewTargetParameters);

        [PreserveSig]
        HRESULT GetContainingOutput(out IDXGIOutput ppOutput);

        [PreserveSig]
        HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);

        [PreserveSig]
        HRESULT GetLastPresentCount(out int pLastPresentCount);
    }
}
