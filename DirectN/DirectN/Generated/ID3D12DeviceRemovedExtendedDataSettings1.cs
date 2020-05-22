// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(13582,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("dbd5ae51-3317-4f0a-adf9-1d7cedcaae0b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DeviceRemovedExtendedDataSettings1 : ID3D12DeviceRemovedExtendedDataSettings
    {
        // ID3D12DeviceRemovedExtendedDataSettings
        [PreserveSig]
        new void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT Enablement);
        
        [PreserveSig]
        new void SetPageFaultEnablement(D3D12_DRED_ENABLEMENT Enablement);
        
        [PreserveSig]
        new void SetWatsonDumpEnablement(D3D12_DRED_ENABLEMENT Enablement);
        
        // ID3D12DeviceRemovedExtendedDataSettings1
        [PreserveSig]
        void SetBreadcrumbContextEnablement(D3D12_DRED_ENABLEMENT Enablement);
    }
}
