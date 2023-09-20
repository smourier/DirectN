// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9727a022-cf1d-4dda-9eba-effa653fc506"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DeviceRemovedExtendedData1 : ID3D12DeviceRemovedExtendedData
    {
        // ID3D12DeviceRemovedExtendedData
        [PreserveSig]
        new HRESULT GetAutoBreadcrumbsOutput(/* _Out_ */ out D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT pOutput);
        
        [PreserveSig]
        new HRESULT GetPageFaultAllocationOutput(/* _Out_ */ out D3D12_DRED_PAGE_FAULT_OUTPUT pOutput);
        
        // ID3D12DeviceRemovedExtendedData1
        [PreserveSig]
        HRESULT GetAutoBreadcrumbsOutput1(/* _Out_ */ out D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1 pOutput);
        
        [PreserveSig]
        HRESULT GetPageFaultAllocationOutput1(/* _Out_ */ out D3D12_DRED_PAGE_FAULT_OUTPUT1 pOutput);
    }
}
