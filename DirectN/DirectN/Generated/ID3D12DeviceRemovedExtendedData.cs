// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("98931d33-5ae8-4791-aa3c-1a73a2934e71"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DeviceRemovedExtendedData
    {
        [PreserveSig]
        HRESULT GetAutoBreadcrumbsOutput(/* _Out_ */ out D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT pOutput);
        
        [PreserveSig]
        HRESULT GetPageFaultAllocationOutput(/* _Out_ */ out D3D12_DRED_PAGE_FAULT_OUTPUT pOutput);
    }
}
