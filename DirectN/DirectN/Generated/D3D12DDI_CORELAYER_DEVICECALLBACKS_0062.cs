// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(8496,9)
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_ALLOCATE_CB_0022 = System.IntPtr;
using PFND3D12DDI_CREATECONTEXT_CB = System.IntPtr;
using PFND3D12DDI_CREATECONTEXTVIRTUAL_CB = System.IntPtr;
using PFND3D12DDI_CREATEHWQUEUE_CB_0050 = System.IntPtr;
using PFND3D12DDI_CREATEPAGINGQUEUE_CB = System.IntPtr;
using PFND3D12DDI_CREATESCHEDULINGGROUPCONTEXT_CB_0050 = System.IntPtr;
using PFND3D12DDI_CREATESCHEDULINGGROUPCONTEXTVIRTUAL_CB_0050 = System.IntPtr;
using PFND3D12DDI_DEALLOCATE_CB_0022 = System.IntPtr;
using PFND3D12DDI_DESTROYCONTEXT_CB = System.IntPtr;
using PFND3D12DDI_DESTROYPAGINGQUEUE_CB = System.IntPtr;
using PFND3D12DDI_EVICT_CB = System.IntPtr;
using PFND3D12DDI_MAKERESIDENT_CB = System.IntPtr;
using PFND3D12DDI_OFFERALLOCATIONS_CB = System.IntPtr;
using PFND3D12DDI_QUEUEPROCESSINGWORK_CB_0062 = System.IntPtr;
using PFND3D12DDI_RECLAIMALLOCATIONS2_CB = System.IntPtr;
using PFND3D12DDI_SETCOMMANDLISTDDITABLE_CB = System.IntPtr;
using PFND3D12DDI_SETCOMMANDLISTERROR_CB = System.IntPtr;
using PFND3D12DDI_SETERROR_CB = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_CORELAYER_DEVICECALLBACKS_0062
    {
        public IntPtr pfnSetErrorCb;
        public IntPtr pfnSetCommandListErrorCb;
        public IntPtr pfnSetCommandListDDITableCb;
        public IntPtr pfnCreateContextCb;
        public IntPtr pfnCreateContextVirtualCb;
        public IntPtr pfnDestroyContextCb;
        public IntPtr pfnCreatePagingQueueCb;
        public IntPtr pfnDestroyPagingQueueCb;
        public IntPtr pfnMakeResidentCb;
        public IntPtr pfnEvictCb;
        public IntPtr pfnReclaimAllocations2Cb;
        public IntPtr pfnOfferAllocationsCb;
        public IntPtr pfnAllocateCb;
        public IntPtr pfnDeallocateCb;
        public IntPtr pfnCreateSchedulingGroupContextCb;
        public IntPtr pfnCreateSchedulingGroupContextVirtualCb;
        public IntPtr pfnCreateHwQueueCb;
        public IntPtr pfnQueueBackgroundProcessingWorkCb;
    }
}
