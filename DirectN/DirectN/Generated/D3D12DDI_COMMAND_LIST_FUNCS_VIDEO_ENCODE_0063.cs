// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(11959,9)
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_BEGIN_END_QUERY_0003 = System.IntPtr;
using PFND3D12DDI_CLOSECOMMANDLIST = System.IntPtr;
using PFND3D12DDI_DISCARD_RESOURCE_0003 = System.IntPtr;
using PFND3D12DDI_ESTIMATE_MOTION_0053 = System.IntPtr;
using PFND3D12DDI_EXECUTE_VIDEO_EXTENSION_COMMAND_0063 = System.IntPtr;
using PFND3D12DDI_INITIALIZE_VIDEO_EXTENSION_COMMAND_0063 = System.IntPtr;
using PFND3D12DDI_RESETCOMMANDLIST_0040 = System.IntPtr;
using PFND3D12DDI_RESOLVE_QUERY_DATA = System.IntPtr;
using PFND3D12DDI_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_0060 = System.IntPtr;
using PFND3D12DDI_RESOURCEBARRIER_0022 = System.IntPtr;
using PFND3D12DDI_SET_MARKER = System.IntPtr;
using PFND3D12DDI_SET_PREDICATION = System.IntPtr;
using PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 = System.IntPtr;
using PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_ENCODE_0063
    {
        public IntPtr pfnCloseCommandList;
        public IntPtr pfnResetCommandList;
        public IntPtr pfnDiscardResource;
        public IntPtr pfnSetMarker;
        public IntPtr pfnSetPredication;
        public IntPtr pfnBeginQuery;
        public IntPtr pfnEndQuery;
        public IntPtr pfnResolveQueryData;
        public IntPtr pfnResourceBarrier;
        public IntPtr pfnEstimateMotion;
        public IntPtr pfnSetProtectedResourceSession;
        public IntPtr pfnWriteBufferImmediate;
        public IntPtr pfnResolveVideoMotionVectorHeap;
        public IntPtr pfnInitializeVideoExtensionCommand;
        public IntPtr pfnExecuteVideoExtensionCommand;
    }
}
