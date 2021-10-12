// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(14621,5)
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
