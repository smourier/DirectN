// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgi.h(1710,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGISwapChain : IDXGIDeviceSubObject
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
        HRESULT Present(/* [in] */ uint SyncInterval, /* [in] */ uint Flags);
        
        [PreserveSig]
        HRESULT GetBuffer(/* [in] */ uint Buffer, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out][in] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppSurface);
        
        [PreserveSig]
        HRESULT SetFullscreenState(/* [in] */ bool Fullscreen, /* [annotation][in] _In_opt_ */ IDXGIOutput pTarget);
        
        [PreserveSig]
        HRESULT GetFullscreenState(/* optional(BOOL) */ IntPtr pFullscreen, /* [annotation][out] _COM_Outptr_opt_result_maybenull_ */ out IDXGIOutput ppTarget);
        
        [PreserveSig]
        HRESULT GetDesc(/* [annotation][out] _Out_ */ out DXGI_SWAP_CHAIN_DESC pDesc);
        
        [PreserveSig]
        HRESULT ResizeBuffers(/* [in] */ uint BufferCount, /* [in] */ uint Width, /* [in] */ uint Height, /* [in] */ DXGI_FORMAT NewFormat, /* [in] */ uint SwapChainFlags);
        
        [PreserveSig]
        HRESULT ResizeTarget(/* [annotation][in] _In_ */ ref DXGI_MODE_DESC pNewTargetParameters);
        
        [PreserveSig]
        HRESULT GetContainingOutput(/* [annotation][out] _COM_Outptr_ */ out IDXGIOutput ppOutput);
        
        [PreserveSig]
        HRESULT GetFrameStatistics(/* [annotation][out] _Out_ */ out DXGI_FRAME_STATISTICS pStats);
        
        [PreserveSig]
        HRESULT GetLastPresentCount(/* [annotation][out] _Out_ */ out uint pLastPresentCount);
    }
}
