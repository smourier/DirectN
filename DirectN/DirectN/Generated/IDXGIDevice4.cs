// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_5.h(907,5)
using System;
using System.Runtime.InteropServices;
using DXGI_OFFER_RESOURCE_PRIORITY = DirectN._DXGI_OFFER_RESOURCE_PRIORITY;

namespace DirectN
{
    [Guid("95b4f95f-d8da-4ca4-9ee6-3b76d5968a10"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIDevice4
    {
        [PreserveSig]
        HRESULT OfferResources1(/* [annotation][in] _In_ */ uint NumResources, /* [annotation][size_is][in] _In_reads_(NumResources) */ out IntPtr ppResources, /* [annotation][in] _In_ */ DXGI_OFFER_RESOURCE_PRIORITY Priority, /* [annotation][in] _In_ */ uint Flags);
        
        [PreserveSig]
        HRESULT ReclaimResources1(/* [annotation][in] _In_ */ uint NumResources, /* [annotation][size_is][in] _In_reads_(NumResources) */ out IntPtr ppResources, /* [annotation][size_is][out] _Out_writes_all_(NumResources) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] _DXGI_RECLAIM_RESOURCE_RESULTS[] pResults);
    }
}
