// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(13399,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000000-0000-0000-0000-000000000000"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DeviceRemovedExtendedData
    {
        [PreserveSig]
        HRESULT GetAutoBreadcrumbsOutput(ref D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT pOutput);
        
        [PreserveSig]
        HRESULT GetPageFaultAllocationOutput(ref D3D12_DRED_PAGE_FAULT_OUTPUT pOutput);
    }
}
