// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("61552388-01ab-4008-a436-83db189566ea"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DeviceRemovedExtendedDataSettings2 : ID3D12DeviceRemovedExtendedDataSettings1
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
        new void SetBreadcrumbContextEnablement(D3D12_DRED_ENABLEMENT Enablement);
        
        // ID3D12DeviceRemovedExtendedDataSettings2
        [PreserveSig]
        void UseMarkersOnlyAutoBreadcrumbs(bool MarkersOnly);
    }
}
