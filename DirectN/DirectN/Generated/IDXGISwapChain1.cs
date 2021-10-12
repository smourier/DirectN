// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dxgi1_2.h(1307,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("790a45f7-0d42-4876-983a-0a55cfe6f4aa"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGISwapChain1 : IDXGISwapChain
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
        
        // IDXGISwapChain
        [PreserveSig]
        new HRESULT Present(/* [in] */ uint SyncInterval, /* [in] */ uint Flags);
        
        [PreserveSig]
        new HRESULT GetBuffer(/* [in] */ uint Buffer, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out][in] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppSurface);
        
        [PreserveSig]
        new HRESULT SetFullscreenState(/* [in] */ bool Fullscreen, /* [annotation][in] _In_opt_ */ IDXGIOutput pTarget);
        
        [PreserveSig]
        new HRESULT GetFullscreenState(/* optional(BOOL) */ IntPtr pFullscreen, /* [annotation][out] _COM_Outptr_opt_result_maybenull_ */ out IDXGIOutput ppTarget);
        
        [PreserveSig]
        new HRESULT GetDesc(/* [annotation][out] _Out_ */ out DXGI_SWAP_CHAIN_DESC pDesc);
        
        [PreserveSig]
        new HRESULT ResizeBuffers(/* [in] */ uint BufferCount, /* [in] */ uint Width, /* [in] */ uint Height, /* [in] */ DXGI_FORMAT NewFormat, /* [in] */ uint SwapChainFlags);
        
        [PreserveSig]
        new HRESULT ResizeTarget(/* [annotation][in] _In_ */ ref DXGI_MODE_DESC pNewTargetParameters);
        
        [PreserveSig]
        new HRESULT GetContainingOutput(/* [annotation][out] _COM_Outptr_ */ out IDXGIOutput ppOutput);
        
        [PreserveSig]
        new HRESULT GetFrameStatistics(/* [annotation][out] _Out_ */ out DXGI_FRAME_STATISTICS pStats);
        
        [PreserveSig]
        new HRESULT GetLastPresentCount(/* [annotation][out] _Out_ */ out uint pLastPresentCount);
        
        // IDXGISwapChain1
        [PreserveSig]
        HRESULT GetDesc1(/* [annotation][out] _Out_ */ out DXGI_SWAP_CHAIN_DESC1 pDesc);
        
        [PreserveSig]
        HRESULT GetFullscreenDesc(/* [annotation][out] _Out_ */ out DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetHwnd(/* [annotation][out] _Out_ */ out IntPtr pHwnd);
        
        [PreserveSig]
        HRESULT GetCoreWindow(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid refiid, /* [annotation][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);
        
        [PreserveSig]
        HRESULT Present1(/* [in] */ uint SyncInterval, /* [in] */ uint PresentFlags, /* [annotation][in] _In_ */ ref DXGI_PRESENT_PARAMETERS pPresentParameters);
        
        [PreserveSig]
        bool IsTemporaryMonoSupported();
        
        [PreserveSig]
        HRESULT GetRestrictToOutput(/* [annotation][out] _Out_ */ out IDXGIOutput ppRestrictToOutput);
        
        [PreserveSig]
        HRESULT SetBackgroundColor(/* [annotation][in] _In_ */ ref _D3DCOLORVALUE pColor);
        
        [PreserveSig]
        HRESULT GetBackgroundColor(/* [annotation][out] _Out_ */ out _D3DCOLORVALUE pColor);
        
        [PreserveSig]
        HRESULT SetRotation(/* [annotation][in] _In_ */ DXGI_MODE_ROTATION Rotation);
        
        [PreserveSig]
        HRESULT GetRotation(/* [annotation][out] _Out_ */ out DXGI_MODE_ROTATION pRotation);
    }
}
