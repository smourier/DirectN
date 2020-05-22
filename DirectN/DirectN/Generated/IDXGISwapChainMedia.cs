// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgi1_3.h(1689,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("dd95b90b-f05f-4f6a-bd65-25bfb264bd84"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
