// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\videoacc.h(244,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("256a6a22-fbad-11d1-82bf-00a0c9696c8f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMVideoAccelerator
    {
        [PreserveSig]
        HRESULT GetVideoAcceleratorGUIDs(/* [annotation][out][in] _Inout_ */ ref int pdwNumGuidsSupported, /* [annotation][out][in] _Out_writes_to_opt_(*pdwNumGuidsSupported, *pdwNumGuidsSupported) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] Guid[] pGuidsSupported);

        [PreserveSig]
        HRESULT GetUncompFormatsSupported(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pGuid, /* [annotation][out][in] _Inout_ */ ref int pdwNumFormatsSupported, /* [annotation][out][in] _Out_writes_to_opt_(*pdwNumFormatsSupported, *pdwNumFormatsSupported) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] pFormatsSupported);

        [PreserveSig]
        HRESULT GetInternalMemInfo(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pGuid, /* [in] */ ref _tag_AMVAUncompDataInfo pamvaUncompDataInfo, /* [annotation][out][in] _Inout_ */ ref _tag_AMVAInternalMemInfo pamvaInternalMemInfo);

        [PreserveSig]
        HRESULT GetCompBufferInfo(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pGuid, /* [in] */ ref _tag_AMVAUncompDataInfo pamvaUncompDataInfo, /* [annotation][out][in] _Inout_ */ ref int pdwNumTypesCompBuffers, /* [annotation][out] _Out_writes_to_opt_(*pdwNumTypesCompBuffers, *pdwNumTypesCompBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] _tag_AMVACompBufferInfo[] pamvaCompBufferInfo);

        [PreserveSig]
        HRESULT GetInternalCompBufferInfo(/* [annotation][out][in] _Inout_ */ ref int pdwNumTypesCompBuffers, /* [annotation][out] _Out_writes_to_opt_(*pdwNumTypesCompBuffers, *pdwNumTypesCompBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] _tag_AMVACompBufferInfo[] pamvaCompBufferInfo);

        [PreserveSig]
        HRESULT BeginFrame(/* [in] */ ref _tag_AMVABeginFrameInfo amvaBeginFrameInfo);

        [PreserveSig]
        HRESULT EndFrame(/* [in] */ ref _tag_AMVAEndFrameInfo pEndFrameInfo);

        [PreserveSig]
        HRESULT GetBuffer(/* [in] */ uint dwTypeIndex, /* [in] */ uint dwBufferIndex, /* [in] */ bool bReadOnly, /* [annotation][out] _Out_ */ out IntPtr ppBuffer, /* [annotation][out] _Out_ */ out int lpStride);

        [PreserveSig]
        HRESULT ReleaseBuffer(/* [in] */ uint dwTypeIndex, /* [in] */ uint dwBufferIndex);

        [PreserveSig]
        HRESULT Execute(/* [in] */ uint dwFunction, /* [in] */ IntPtr lpPrivateInputData, /* [in] */ uint cbPrivateInputData, /* [in] */ IntPtr lpPrivateOutputDat, /* [in] */ uint cbPrivateOutputData, /* [in] */ int dwNumBuffers, /* [annotation][in] _In_reads_(dwNumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] _tag_AMVABUFFERINFO[] pamvaBufferInfo);

        [PreserveSig]
        HRESULT QueryRenderStatus(/* [in] */ uint dwTypeIndex, /* [in] */ uint dwBufferIndex, /* [in] */ uint dwFlags);

        [PreserveSig]
        HRESULT DisplayFrame(/* [in] */ uint dwFlipToIndex, /* [in] */ IMediaSample pMediaSample);
    }
}
