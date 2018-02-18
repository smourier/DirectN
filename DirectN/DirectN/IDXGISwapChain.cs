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

    [Guid("790a45f7-0d42-4876-983a-0a55cfe6f4aa"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISwapChain1 : IDXGISwapChain
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
        HRESULT GetDesc1(out DXGI_SWAP_CHAIN_DESC1 pDesc);

        [PreserveSig]
        HRESULT GetFullscreenDesc(out DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc);

        [PreserveSig]
        HRESULT GetHwnd(out IntPtr pHwnd);

        [PreserveSig]
        HRESULT GetCoreWindow([MarshalAs(UnmanagedType.LPStruct)] Guid refiid, [MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);

        [PreserveSig]
        HRESULT Present1(int SyncInterval, DXGI_PRESENT PresentFlags, ref DXGI_PRESENT_PARAMETERS pPresentParameters);

        [PreserveSig]
        bool IsTemporaryMonoSupported();

        [PreserveSig]
        HRESULT GetRestrictToOutput(out IDXGIOutput ppRestrictToOutput);

        [PreserveSig]
        HRESULT SetBackgroundColor(ref DXGI_RGBA pColor);

        [PreserveSig]
        HRESULT GetBackgroundColor(out DXGI_RGBA pColor);

        [PreserveSig]
        HRESULT SetRotation(DXGI_MODE_ROTATION Rotation);

        [PreserveSig]
        HRESULT GetRotation(out DXGI_MODE_ROTATION pRotation);
    }

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
        HRESULT SetSourceSize(int Width,int Height);

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

    [Guid("94d99bdb-f1f8-4ab0-b236-7da0170edab1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISwapChain3 : IDXGISwapChain2
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
        new HRESULT SetSourceSize(int Width, int Height);

        [PreserveSig]
        new HRESULT GetSourceSize(out int pWidth, out int pHeight);

        [PreserveSig]
        new HRESULT SetMaximumFrameLatency(int MaxLatency);

        [PreserveSig]
        new HRESULT GetMaximumFrameLatency(out int pMaxLatency);

        [PreserveSig]
        new IntPtr GetFrameLatencyWaitableObject();

        [PreserveSig]
        new HRESULT SetMatrixTransform(ref DXGI_MATRIX_3X2_F pMatrix);

        [PreserveSig]
        new HRESULT GetMatrixTransform(out DXGI_MATRIX_3X2_F pMatrix);

        // IDXGISwapChain3
        [PreserveSig]
        int GetCurrentBackBufferIndex();
        
        [PreserveSig]
        HRESULT CheckColorSpaceSupport(DXGI_COLOR_SPACE_TYPE ColorSpace, out DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG pColorSpaceSupport);
        
        [PreserveSig]
        HRESULT SetColorSpace1(DXGI_COLOR_SPACE_TYPE ColorSpace);
        
        [PreserveSig]
        HRESULT ResizeBuffers1(
            int BufferCount,
            int Width,
            int Height,
            DXGI_FORMAT Format,
            int SwapChainFlags,
            int[] pCreationNodeMask,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown)]
            object[] ppPresentQueue);
    }

    // dxgi1_5.h
    [Guid("3D585D5A-BD4A-489E-B1F4-3DBCB6452FFB"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISwapChain4 : IDXGISwapChain3
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
        new HRESULT SetSourceSize(int Width, int Height);

        [PreserveSig]
        new HRESULT GetSourceSize(out int pWidth, out int pHeight);

        [PreserveSig]
        new HRESULT SetMaximumFrameLatency(int MaxLatency);

        [PreserveSig]
        new HRESULT GetMaximumFrameLatency(out int pMaxLatency);

        [PreserveSig]
        new IntPtr GetFrameLatencyWaitableObject();

        [PreserveSig]
        new HRESULT SetMatrixTransform(ref DXGI_MATRIX_3X2_F pMatrix);

        [PreserveSig]
        new HRESULT GetMatrixTransform(out DXGI_MATRIX_3X2_F pMatrix);

        // IDXGISwapChain3
        [PreserveSig]
        new int GetCurrentBackBufferIndex();

        [PreserveSig]
        new HRESULT CheckColorSpaceSupport(DXGI_COLOR_SPACE_TYPE ColorSpace, out DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG pColorSpaceSupport);

        [PreserveSig]
        new HRESULT SetColorSpace1(DXGI_COLOR_SPACE_TYPE ColorSpace);

        [PreserveSig]
        new HRESULT ResizeBuffers1(
            int BufferCount,
            int Width,
            int Height,
            DXGI_FORMAT Format,
            int SwapChainFlags,
            int[] pCreationNodeMask,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown)]
            object[] ppPresentQueue);

        // IDXGISwapChain4
        [PreserveSig]
        HRESULT SetHDRMetaData(DXGI_HDR_METADATA_TYPE Type, int Size, IntPtr pMetaData);
    }
}
