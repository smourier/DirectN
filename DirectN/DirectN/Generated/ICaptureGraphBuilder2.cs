// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("93e5a4e0-2d50-11d2-abfa-00a0c9c6e38d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ICaptureGraphBuilder2
    {
        [PreserveSig]
        HRESULT SetFiltergraph(/* [in] */ IGraphBuilder pfg);
        
        [PreserveSig]
        HRESULT GetFiltergraph(/* [annotation][out] _Out_ */ out IGraphBuilder ppfg);
        
        [PreserveSig]
        HRESULT SetOutputFileName(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pType, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpstrFile, /* [annotation][out] _Outptr_ */ out IBaseFilter ppf, /* [annotation][out] _Outptr_opt_ */ out IFileSinkFilter ppSink);
        
        [PreserveSig]
        HRESULT FindInterface(/* optional(GUID) */ IntPtr pCategory, /* optional(GUID) */ IntPtr pType, /* [in] */ IBaseFilter pf, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_ */ out IntPtr ppint);
        
        [PreserveSig]
        HRESULT RenderStream(/* optional(GUID) */ IntPtr pCategory, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pType, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pSource, /* [in] */ IBaseFilter pfCompressor, /* [in] */ IBaseFilter pfRenderer);
        
        [PreserveSig]
        HRESULT ControlStream(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCategory, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pType, /* [in] */ IBaseFilter pFilter, /* optional(REFERENCE_TIME) */ IntPtr pstart, /* optional(REFERENCE_TIME) */ IntPtr pstop, /* [in] */ ushort wStartCookie, /* [in] */ ushort wStopCookie);
        
        [PreserveSig]
        HRESULT AllocCapFile(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpstr, /* [in] */ ulong dwlSize);
        
        [PreserveSig]
        HRESULT CopyCaptureFile(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpwstrOld, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpwstrNew, /* [in] */ int fAllowEscAbort, /* [in] */ IAMCopyCaptureFileProgress pCallback);
        
        [PreserveSig]
        HRESULT FindPin(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pSource, /* [in] */ _PinDirection pindir, /* optional(GUID) */ IntPtr pCategory, /* optional(GUID) */ IntPtr pType, /* [in] */ bool fUnconnected, /* [in] */ int num, /* [annotation][out] _Out_ */ out IPin ppPin);
    }
}
