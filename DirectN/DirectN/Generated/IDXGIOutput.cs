// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dxgi.h(1503,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIOutput : IDXGIObject
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
        HRESULT GetDesc(/* [annotation][out] _Out_ */ out DXGI_OUTPUT_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetDisplayModeList(/* [in] */ DXGI_FORMAT EnumFormat, /* [in] */ uint Flags, /* [annotation][out][in] _Inout_ */ ref int pNumModes, /* [annotation][out] _Out_writes_to_opt_(*pNumModes,*pNumModes) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DXGI_MODE_DESC[] pDesc);
        
        [PreserveSig]
        HRESULT FindClosestMatchingMode(/* [annotation][in] _In_ */ ref DXGI_MODE_DESC pModeToMatch, /* [annotation][out] _Out_ */ out DXGI_MODE_DESC pClosestMatch, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);
        
        [PreserveSig]
        HRESULT WaitForVBlank();
        
        [PreserveSig]
        HRESULT TakeOwnership(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDevice, bool Exclusive);
        
        [PreserveSig]
        void ReleaseOwnership();
        
        [PreserveSig]
        HRESULT GetGammaControlCapabilities(/* [annotation][out] _Out_ */ out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);
        
        [PreserveSig]
        HRESULT SetGammaControl(/* [annotation][in] _In_ */ ref DXGI_GAMMA_CONTROL pArray);
        
        [PreserveSig]
        HRESULT GetGammaControl(/* [annotation][out] _Out_ */ out DXGI_GAMMA_CONTROL pArray);
        
        [PreserveSig]
        HRESULT SetDisplaySurface(/* [annotation][in] _In_ */ IDXGISurface pScanoutSurface);
        
        [PreserveSig]
        HRESULT GetDisplaySurfaceData(/* [annotation][in] _In_ */ IDXGISurface pDestination);
        
        [PreserveSig]
        HRESULT GetFrameStatistics(/* [annotation][out] _Out_ */ out DXGI_FRAME_STATISTICS pStats);
    }
}
