// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\videoacc.h(230,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("256a6a22-fbad-11d1-82bf-00a0c9696c8f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMVideoAccelerator
    {
        [PreserveSig]
        HRESULT GetVideoAcceleratorGUIDs(/* [annotation][out][in] _Inout_ */ IntPtr pdwNumGuidsSupported, /* [annotation][out][in] _Out_writes_to_opt_(*pdwNumGuidsSupported, *pdwNumGuidsSupported) */ Guid pGuidsSupported);
        
        [PreserveSig]
        HRESULT GetUncompFormatsSupported(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pGuid, /* [annotation][out][in] _Inout_ */ IntPtr pdwNumFormatsSupported, /* [annotation][out][in] _Out_writes_to_opt_(*pdwNumFormatsSupported, *pdwNumFormatsSupported) */ IntPtr pFormatsSupported);
        
        [PreserveSig]
        HRESULT GetInternalMemInfo(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pGuid, /* [in] */ ref _tag_AMVAUncompDataInfo pamvaUncompDataInfo, /* [annotation][out][in] _Inout_ */ IntPtr pamvaInternalMemInfo);
        
        [PreserveSig]
        HRESULT GetCompBufferInfo(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pGuid, /* [in] */ ref _tag_AMVAUncompDataInfo pamvaUncompDataInfo, /* [annotation][out][in] _Inout_ */ IntPtr pdwNumTypesCompBuffers, /* [annotation][out] _Out_writes_to_opt_(*pdwNumTypesCompBuffers, *pdwNumTypesCompBuffers) */ IntPtr pamvaCompBufferInfo);
        
        [PreserveSig]
        HRESULT GetInternalCompBufferInfo(/* [annotation][out][in] _Inout_ */ IntPtr pdwNumTypesCompBuffers, /* [annotation][out] _Out_writes_to_opt_(*pdwNumTypesCompBuffers, *pdwNumTypesCompBuffers) */ IntPtr pamvaCompBufferInfo);
        
        [PreserveSig]
        HRESULT BeginFrame(/* [in] */ ref _tag_AMVABeginFrameInfo amvaBeginFrameInfo);
        
        [PreserveSig]
        HRESULT EndFrame(/* [in] */ ref _tag_AMVAEndFrameInfo pEndFrameInfo);
        
        [PreserveSig]
        HRESULT GetBuffer(/* [in] */ uint dwTypeIndex, /* [in] */ uint dwBufferIndex, /* [in] */ bool bReadOnly, /* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppBuffer, /* [annotation][out] _Out_ */ out long lpStride);
        
        [PreserveSig]
        HRESULT ReleaseBuffer(/* [in] */ uint dwTypeIndex, /* [in] */ uint dwBufferIndex);
        
        [PreserveSig]
        HRESULT Execute(/* [in] */ uint dwFunction, /* [in] */ IntPtr lpPrivateInputData, /* [in] */ uint cbPrivateInputData, /* [in] */ IntPtr lpPrivateOutputDat, /* [in] */ uint cbPrivateOutputData, /* [in] */ uint dwNumBuffers, /* [annotation][in] _In_reads_(dwNumBuffers) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] _tag_AMVABUFFERINFO[] pamvaBufferInfo);
        
        [PreserveSig]
        HRESULT QueryRenderStatus(/* [in] */ uint dwTypeIndex, /* [in] */ uint dwBufferIndex, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT DisplayFrame(/* [in] */ uint dwFlipToIndex, /* [in] */ ref int pMediaSample);
    }
}
