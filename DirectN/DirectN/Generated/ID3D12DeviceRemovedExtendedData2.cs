// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("67fc5816-e4ca-4915-bf18-42541272da54"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DeviceRemovedExtendedData2 : ID3D12DeviceRemovedExtendedData1
    {
        // ID3D12DeviceRemovedExtendedData
        [PreserveSig]
        new HRESULT GetAutoBreadcrumbsOutput(/* _Out_ */ out D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT pOutput);
        
        [PreserveSig]
        new HRESULT GetPageFaultAllocationOutput(/* _Out_ */ out D3D12_DRED_PAGE_FAULT_OUTPUT pOutput);
        
        // ID3D12DeviceRemovedExtendedData1
        [PreserveSig]
        new HRESULT GetAutoBreadcrumbsOutput1(/* _Out_ */ out D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1 pOutput);
        
        [PreserveSig]
        new HRESULT GetPageFaultAllocationOutput1(/* _Out_ */ out D3D12_DRED_PAGE_FAULT_OUTPUT1 pOutput);
        
        // ID3D12DeviceRemovedExtendedData2
        [PreserveSig]
        HRESULT GetPageFaultAllocationOutput2(/* _Out_ */ out D3D12_DRED_PAGE_FAULT_OUTPUT2 pOutput);
        
        [PreserveSig]
        D3D12_DRED_DEVICE_STATE GetDeviceState();
    }
}
