using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("dd95b90b-f05f-4f6a-bd65-25bfb264bd84"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGISwapChainMedia
    {
        [PreserveSig]
        HRESULT GetFrameStatisticsMedia(out DXGI_FRAME_STATISTICS_MEDIA pStats);

        [PreserveSig]
        HRESULT SetPresentDuration(int Duration);
        
        [PreserveSig]
        HRESULT CheckPresentDurationSupport(int DesiredPresentDuration, out int pClosestSmallerPresentDuration, out int pClosestLargerPresentDuration);
    }
}
