// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_5.h(1184,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7632e1f5-ee65-4dca-87fd-84cd75f8838d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIFactory5
    {
        [PreserveSig]
        HRESULT CheckFeatureSupport(DXGI_FEATURE Feature, /* [annotation] _Inout_updates_bytes_(FeatureSupportDataSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pFeatureSupportData, uint FeatureSupportDataSize);
    }
}
