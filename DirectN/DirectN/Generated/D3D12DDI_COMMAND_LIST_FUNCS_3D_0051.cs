﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(7182,9)
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_BEGIN_END_QUERY_0003 = System.IntPtr;
using PFND3D12DDI_BLT = System.IntPtr;
using PFND3D12DDI_CLEAR_DEPTH_STENCIL_VIEW_0003 = System.IntPtr;
using PFND3D12DDI_CLEAR_RENDER_TARGET_VIEW_0003 = System.IntPtr;
using PFND3D12DDI_CLEAR_ROOT_ARGUMENTS = System.IntPtr;
using PFND3D12DDI_CLEAR_UNORDERED_ACCESS_VIEW_FLOAT_0003 = System.IntPtr;
using PFND3D12DDI_CLEAR_UNORDERED_ACCESS_VIEW_UINT_0003 = System.IntPtr;
using PFND3D12DDI_CLOSECOMMANDLIST = System.IntPtr;
using PFND3D12DDI_COPYBUFFERREGION_0003 = System.IntPtr;
using PFND3D12DDI_COPYTEXTUREREGION_0003 = System.IntPtr;
using PFND3D12DDI_COPYTILES = System.IntPtr;
using PFND3D12DDI_DISCARD_RESOURCE_0003 = System.IntPtr;
using PFND3D12DDI_DISPATCH = System.IntPtr;
using PFND3D12DDI_DRAWINDEXEDINSTANCED = System.IntPtr;
using PFND3D12DDI_DRAWINSTANCED = System.IntPtr;
using PFND3D12DDI_EXECUTE_BUNDLE = System.IntPtr;
using PFND3D12DDI_EXECUTE_INDIRECT = System.IntPtr;
using PFND3D12DDI_IA_SET_INDEX_BUFFER = System.IntPtr;
using PFND3D12DDI_IA_SET_VERTEX_BUFFERS_0003 = System.IntPtr;
using PFND3D12DDI_IA_SETTOPOLOGY_0003 = System.IntPtr;
using PFND3D12DDI_OM_SET_RENDER_TARGETS_0003 = System.IntPtr;
using PFND3D12DDI_OM_SETBLENDFACTOR = System.IntPtr;
using PFND3D12DDI_OM_SETDEPTHBOUNDS_0025 = System.IntPtr;
using PFND3D12DDI_OM_SETSTENCILREF = System.IntPtr;
using PFND3D12DDI_PRESENT_0051 = System.IntPtr;
using PFND3D12DDI_RESETCOMMANDLIST_0040 = System.IntPtr;
using PFND3D12DDI_RESOLVE_QUERY_DATA = System.IntPtr;
using PFND3D12DDI_RESOURCEBARRIER_0022 = System.IntPtr;
using PFND3D12DDI_RESOURCECOPY = System.IntPtr;
using PFND3D12DDI_RESOURCERESOLVESUBRESOURCE = System.IntPtr;
using PFND3D12DDI_RESOURCERESOLVESUBRESOURCEREGION_0027 = System.IntPtr;
using PFND3D12DDI_RS_SETSCISSORRECTS_0003 = System.IntPtr;
using PFND3D12DDI_RS_SETVIEWPORTS_0003 = System.IntPtr;
using PFND3D12DDI_SET_DESCRIPTOR_HEAPS_0003 = System.IntPtr;
using PFND3D12DDI_SET_MARKER = System.IntPtr;
using PFND3D12DDI_SET_PIPELINE_STATE = System.IntPtr;
using PFND3D12DDI_SET_PREDICATION = System.IntPtr;
using PFND3D12DDI_SET_ROOT_32BIT_CONSTANT = System.IntPtr;
using PFND3D12DDI_SET_ROOT_32BIT_CONSTANTS_0003 = System.IntPtr;
using PFND3D12DDI_SET_ROOT_BUFFER_VIEW = System.IntPtr;
using PFND3D12DDI_SET_ROOT_DESCRIPTOR_TABLE = System.IntPtr;
using PFND3D12DDI_SET_ROOT_SIGNATURE = System.IntPtr;
using PFND3D12DDI_SETPROTECTEDRESOURCESESSION_0030 = System.IntPtr;
using PFND3D12DDI_SETSAMPLEPOSITIONS_0027 = System.IntPtr;
using PFND3D12DDI_SETVIEWINSTANCEMASK_0033 = System.IntPtr;
using PFND3D12DDI_SO_SET_TARGETS_0003 = System.IntPtr;
using PFND3D12DDI_WRITEBUFFERIMMEDIATE_0032 = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_COMMAND_LIST_FUNCS_3D_0051
    {
        public IntPtr pfnCloseCommandList;
        public IntPtr pfnResetCommandList;
        public IntPtr pfnDrawInstanced;
        public IntPtr pfnDrawIndexedInstanced;
        public IntPtr pfnDispatch;
        public IntPtr pfnClearUnorderedAccessViewUint;
        public IntPtr pfnClearUnorderedAccessViewFloat;
        public IntPtr pfnClearRenderTargetView;
        public IntPtr pfnClearDepthStencilView;
        public IntPtr pfnDiscardResource;
        public IntPtr pfnCopyTextureRegion;
        public IntPtr pfnResourceCopy;
        public IntPtr pfnCopyTiles;
        public IntPtr pfnCopyBufferRegion;
        public IntPtr pfnResourceResolveSubresource;
        public IntPtr pfnExecuteBundle;
        public IntPtr pfnExecuteIndirect;
        public IntPtr pfnResourceBarrier;
        public IntPtr pfnBlt;
        public IntPtr pfnPresent;
        public IntPtr pfnBeginQuery;
        public IntPtr pfnEndQuery;
        public IntPtr pfnResolveQueryData;
        public IntPtr pfnSetPredication;
        public IntPtr pfnIaSetTopology;
        public IntPtr pfnRsSetViewports;
        public IntPtr pfnRsSetScissorRects;
        public IntPtr pfnOmSetBlendFactor;
        public IntPtr pfnOmSetStencilRef;
        public IntPtr pfnSetPipelineState;
        public IntPtr pfnSetDescriptorHeaps;
        public IntPtr pfnSetComputeRootSignature;
        public IntPtr pfnSetGraphicsRootSignature;
        public IntPtr pfnSetComputeRootDescriptorTable;
        public IntPtr pfnSetGraphicsRootDescriptorTable;
        public IntPtr pfnSetComputeRoot32BitConstant;
        public IntPtr pfnSetGraphicsRoot32BitConstant;
        public IntPtr pfnSetComputeRoot32BitConstants;
        public IntPtr pfnSetGraphicsRoot32BitConstants;
        public IntPtr pfnSetComputeRootConstantBufferView;
        public IntPtr pfnSetGraphicsRootConstantBufferView;
        public IntPtr pfnSetComputeRootShaderResourceView;
        public IntPtr pfnSetGraphicsRootShaderResourceView;
        public IntPtr pfnSetComputeRootUnorderedAccessView;
        public IntPtr pfnSetGraphicsRootUnorderedAccessView;
        public IntPtr pfnIASetIndexBuffer;
        public IntPtr pfnIASetVertexBuffers;
        public IntPtr pfnSOSetTargets;
        public IntPtr pfnOMSetRenderTargets;
        public IntPtr pfnSetMarker;
        public IntPtr pfnClearRootArguments;
        public IntPtr pfnAtomicCopyBufferRegion;
        public IntPtr pfnOMSetDepthBounds;
        public IntPtr pfnSetSamplePositions;
        public IntPtr pfnResourceResolveSubresourceRegion;
        public IntPtr pfnSetProtectedResourceSession;
        public IntPtr pfnWriteBufferImmediate;
        public IntPtr pfnSetViewInstanceMask;
    }
}
