// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\dxgi1_4.h(554,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("dc7dca35-2196-414d-9f53-617884032a60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIOutput4 : IDXGIOutput3
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
        
        // IDXGIOutput
        [PreserveSig]
        new HRESULT GetDesc(/* [annotation][out] _Out_ */ out DXGI_OUTPUT_DESC pDesc);
        
        [PreserveSig]
        new HRESULT GetDisplayModeList(/* [in] */ DXGI_FORMAT EnumFormat, /* [in] */ uint Flags, /* [annotation][out][in] _Inout_ */ ref int pNumModes, /* [annotation][out] _Out_writes_to_opt_(*pNumModes,*pNumModes) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DXGI_MODE_DESC[] pDesc);
        
        [PreserveSig]
        new HRESULT FindClosestMatchingMode(/* [annotation][in] _In_ */ ref DXGI_MODE_DESC pModeToMatch, /* [annotation][out] _Out_ */ out DXGI_MODE_DESC pClosestMatch, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);
        
        [PreserveSig]
        new HRESULT WaitForVBlank();
        
        [PreserveSig]
        new HRESULT TakeOwnership(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, bool Exclusive);
        
        [PreserveSig]
        new void ReleaseOwnership();
        
        [PreserveSig]
        new HRESULT GetGammaControlCapabilities(/* [annotation][out] _Out_ */ out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);
        
        [PreserveSig]
        new HRESULT SetGammaControl(/* [annotation][in] _In_ */ ref DXGI_GAMMA_CONTROL pArray);
        
        [PreserveSig]
        new HRESULT GetGammaControl(/* [annotation][out] _Out_ */ out DXGI_GAMMA_CONTROL pArray);
        
        [PreserveSig]
        new HRESULT SetDisplaySurface(/* [annotation][in] _In_ */ IDXGISurface pScanoutSurface);
        
        [PreserveSig]
        new HRESULT GetDisplaySurfaceData(/* [annotation][in] _In_ */ IDXGISurface pDestination);
        
        [PreserveSig]
        new HRESULT GetFrameStatistics(/* [annotation][out] _Out_ */ out DXGI_FRAME_STATISTICS pStats);
        
        // IDXGIOutput1
        [PreserveSig]
        new HRESULT GetDisplayModeList1(/* [in] */ DXGI_FORMAT EnumFormat, /* [in] */ uint Flags, /* [annotation][out][in] _Inout_ */ ref int pNumModes, /* [annotation][out] _Out_writes_to_opt_(*pNumModes,*pNumModes) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DXGI_MODE_DESC1[] pDesc);
        
        [PreserveSig]
        new HRESULT FindClosestMatchingMode1(/* [annotation][in] _In_ */ ref DXGI_MODE_DESC1 pModeToMatch, /* [annotation][out] _Out_ */ out DXGI_MODE_DESC1 pClosestMatch, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);
        
        [PreserveSig]
        new HRESULT GetDisplaySurfaceData1(/* [annotation][in] _In_ */ IDXGIResource pDestination);
        
        [PreserveSig]
        new HRESULT DuplicateOutput(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, /* [annotation][out] _COM_Outptr_ */ out IntPtr ppOutputDuplication);
        
        // IDXGIOutput2
        [PreserveSig]
        new bool SupportsOverlays();
        
        // IDXGIOutput3
        [PreserveSig]
        new HRESULT CheckOverlaySupport(/* [annotation][in] _In_ */ DXGI_FORMAT EnumFormat, /* [annotation][out] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] out object pConcernedDevice, /* [annotation][out] _Out_ */ out uint pFlags);
        
        // IDXGIOutput4
        [PreserveSig]
        HRESULT CheckOverlayColorSpaceSupport(/* [annotation][in] _In_ */ DXGI_FORMAT Format, /* [annotation][in] _In_ */ DXGI_COLOR_SPACE_TYPE ColorSpace, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice, /* [annotation][out] _Out_ */ out uint pFlags);
    }
}
