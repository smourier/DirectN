// generated from <Windows SDK Path>\shared\dxgi1_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dd95b90b-f05f-4f6a-bd65-25bfb264bd84"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGISwapChainMedia
    {
        [PreserveSig]
        HRESULT GetFrameStatisticsMedia(/* [annotation][out] _Out_ */ out DXGI_FRAME_STATISTICS_MEDIA pStats);
        
        [PreserveSig]
        HRESULT SetPresentDuration(uint Duration);
        
        [PreserveSig]
        HRESULT CheckPresentDurationSupport(uint DesiredPresentDuration, /* [annotation][out] _Out_ */ out uint pClosestSmallerPresentDuration, /* [annotation][out] _Out_ */ out uint pClosestLargerPresentDuration);
    }
}
