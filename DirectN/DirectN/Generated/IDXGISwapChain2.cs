using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a8be2ac4-199f-4946-b331-79599fb98de7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISwapChain2 : IDXGISwapChain1
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
        new HRESULT Present(int SyncInterval, DXGI_PRESENT Flags);

        [PreserveSig]
        new HRESULT GetBuffer(int Buffer, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppSurface);

        [PreserveSig]
        new HRESULT SetFullscreenState(bool Fullscreen, IDXGIOutput pTarget);

        [PreserveSig]
        new HRESULT GetFullscreenState(out bool pFullscreen, out IDXGIOutput ppTarget);

        [PreserveSig]
        new HRESULT GetDesc(out DXGI_SWAP_CHAIN_DESC pDesc);

        [PreserveSig]
        new HRESULT ResizeBuffers(
            int BufferCount,
            int Width,
            int Height,
            DXGI_FORMAT NewFormat,
            DXGI_SWAP_CHAIN_FLAG SwapChainFlags);

        [PreserveSig]
        new HRESULT ResizeTarget(ref DXGI_MODE_DESC pNewTargetParameters);

        [PreserveSig]
        new HRESULT GetContainingOutput(out IDXGIOutput ppOutput);

        [PreserveSig]
        new HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);

        [PreserveSig]
        new HRESULT GetLastPresentCount(out int pLastPresentCount);

        // IDXGISwapChain1
        [PreserveSig]
        new HRESULT GetDesc1(out DXGI_SWAP_CHAIN_DESC1 pDesc);

        [PreserveSig]
        new HRESULT GetFullscreenDesc(out DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc);

        [PreserveSig]
        new HRESULT GetHwnd(out IntPtr pHwnd);

        [PreserveSig]
        new HRESULT GetCoreWindow([MarshalAs(UnmanagedType.LPStruct)] Guid refiid, [MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);

        [PreserveSig]
        new HRESULT Present1(int SyncInterval, DXGI_PRESENT PresentFlags, ref DXGI_PRESENT_PARAMETERS pPresentParameters);

        [PreserveSig]
        new bool IsTemporaryMonoSupported();

        [PreserveSig]
        new HRESULT GetRestrictToOutput(out IDXGIOutput ppRestrictToOutput);

        [PreserveSig]
        new HRESULT SetBackgroundColor(ref DXGI_RGBA pColor);

        [PreserveSig]
        new HRESULT GetBackgroundColor(out DXGI_RGBA pColor);

        [PreserveSig]
        new HRESULT SetRotation(DXGI_MODE_ROTATION Rotation);

        [PreserveSig]
        new HRESULT GetRotation(out DXGI_MODE_ROTATION pRotation);

        // IDXGISwapChain2
        [PreserveSig]
        HRESULT SetSourceSize(int Width, int Height);

        [PreserveSig]
        HRESULT GetSourceSize(out int pWidth, out int pHeight);

        [PreserveSig]
        HRESULT SetMaximumFrameLatency(int MaxLatency);

        [PreserveSig]
        HRESULT GetMaximumFrameLatency(out int pMaxLatency);

        [PreserveSig]
        IntPtr GetFrameLatencyWaitableObject();

        [PreserveSig]
        HRESULT SetMatrixTransform(ref DXGI_MATRIX_3X2_F pMatrix);

        [PreserveSig]
        HRESULT GetMatrixTransform(out DXGI_MATRIX_3X2_F pMatrix);
    }
}
