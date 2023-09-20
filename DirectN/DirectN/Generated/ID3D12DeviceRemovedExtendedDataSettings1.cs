// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dbd5ae51-3317-4f0a-adf9-1d7cedcaae0b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
