// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_BEGIN_END_QUERY_0003 = System.IntPtr;
using PFND3D12DDI_CLOSECOMMANDLIST = System.IntPtr;
using PFND3D12DDI_DISCARD_RESOURCE_0003 = System.IntPtr;
using PFND3D12DDI_RESETCOMMANDLIST_0040 = System.IntPtr;
using PFND3D12DDI_RESOLVE_QUERY_DATA = System.IntPtr;
using PFND3D12DDI_RESOURCEBARRIER_0022 = System.IntPtr;
using PFND3D12DDI_SET_MARKER = System.IntPtr;
using PFND3D12DDI_SET_PREDICATION = System.IntPtr;
using PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 = System.IntPtr;
using PFND3D12DDI_VIDEO_DECODE_FRAME_0041_1 = System.IntPtr;
using PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_COMMAND_LIST_FUNCS_VIDEO_DECODE_0041_1
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
        public IntPtr pfnDecodeFrame;
        public IntPtr pfnSetProtectedResourceSession;
        public IntPtr pfnWriteBufferImmediate;
    }
}
