// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxvahd.h(505,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("95f12dfd-d77e-49be-815f-57d579634d6d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXVAHD_Device
    {
        [PreserveSig]
        HRESULT CreateVideoSurface(/* [annotation][in] _In_ */ uint Width, /* [annotation][in] _In_ */ uint Height, /* [annotation][in] _In_ */ int Format, /* [annotation][in] _In_ */ int Pool, /* [annotation][in] _In_ */ uint Usage, /* [annotation][in] _In_ */ _DXVAHD_SURFACE_TYPE Type, /* [annotation][in] _In_ */ uint NumSurfaces, /* [annotation][size_is][out] _Out_writes_(NumSurfaces) */ out IntPtr ppSurfaces, /* optional(HANDLE) */ out IntPtr pSharedHandle);
        
        [PreserveSig]
        HRESULT GetVideoProcessorDeviceCaps(/* [annotation][out] _Out_ */ out _DXVAHD_VPDEVCAPS pCaps);
        
        [PreserveSig]
        HRESULT GetVideoProcessorOutputFormats(/* [annotation][in] _In_ */ uint Count, /* [annotation][size_is][out] _Out_writes_(Count) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] int[] pFormats);
        
        [PreserveSig]
        HRESULT GetVideoProcessorInputFormats(/* [annotation][in] _In_ */ uint Count, /* [annotation][size_is][out] _Out_writes_(Count) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] int[] pFormats);
        
        [PreserveSig]
        HRESULT GetVideoProcessorCaps(/* [annotation][in] _In_ */ uint Count, /* [annotation][size_is][out] _Out_writes_(Count) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] _DXVAHD_VPCAPS[] pCaps);
        
        [PreserveSig]
        HRESULT GetVideoProcessorCustomRates(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pVPGuid, /* [annotation][in] _In_ */ uint Count, /* [annotation][size_is][out] _Out_writes_(Count) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _DXVAHD_CUSTOM_RATE_DATA[] pRates);
        
        [PreserveSig]
        HRESULT GetVideoProcessorFilterRange(/* [annotation][in] _In_ */ _DXVAHD_FILTER Filter, /* [annotation][out] _Out_ */ out _DXVAHD_FILTER_RANGE_DATA pRange);
        
        [PreserveSig]
        HRESULT CreateVideoProcessor(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pVPGuid, /* [annotation][out] _Outptr_ */ out IDXVAHD_VideoProcessor ppVideoProcessor);
    }
}
