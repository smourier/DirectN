// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(13300,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000000-0000-0000-0000-000000000000"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DeviceRemovedExtendedDataSettings
    {
        [PreserveSig]
        void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT __MIDL__ID3D12DeviceRemovedExtendedDataSettings0000);
        
        [PreserveSig]
        void SetPageFaultEnablement(D3D12_DRED_ENABLEMENT __MIDL__ID3D12DeviceRemovedExtendedDataSettings0001);
        
        [PreserveSig]
        void SetWatsonDumpEnablement(D3D12_DRED_ENABLEMENT __MIDL__ID3D12DeviceRemovedExtendedDataSettings0002);
    }
}
