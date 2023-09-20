// generated from <Windows SDK Path>\um\d3d12.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DEVICE_REMOVED_EXTENDED_DATA2
    {
        public HRESULT DeviceRemovedReason;
        public D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1 AutoBreadcrumbsOutput;
        public D3D12_DRED_PAGE_FAULT_OUTPUT1 PageFaultOutput;
    }
}
