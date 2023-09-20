// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("bf87b6e0-8c27-11d0-b3f0-00aa003761c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ICaptureGraphBuilder
    {
        [PreserveSig]
        HRESULT SetFiltergraph(/* [in] */ IGraphBuilder pfg);
        
        [PreserveSig]
        HRESULT GetFiltergraph(/* [annotation][out] _Out_ */ out IGraphBuilder ppfg);
        
        [PreserveSig]
        HRESULT SetOutputFileName(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pType, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpstrFile, /* [annotation][out] _Out_ */ out IBaseFilter ppf, /* [annotation][out] _Out_ */ out IFileSinkFilter ppSink);
        
        [PreserveSig]
        HRESULT FindInterface(/* optional(GUID) */ IntPtr pCategory, /* [in] */ IBaseFilter pf, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppint);
        
        [PreserveSig]
        HRESULT RenderStream(/* optional(GUID) */ IntPtr pCategory, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pSource, /* [in] */ IBaseFilter pfCompressor, /* [in] */ IBaseFilter pfRenderer);
        
        [PreserveSig]
        HRESULT ControlStream(/* optional(GUID) */ IntPtr pCategory, /* [in] */ IBaseFilter pFilter, /* [in] */ ref REFERENCE_TIME pstart, /* [in] */ ref REFERENCE_TIME pstop, /* [in] */ ushort wStartCookie, /* [in] */ ushort wStopCookie);
        
        [PreserveSig]
        HRESULT AllocCapFile(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpstr, /* [in] */ ulong dwlSize);
        
        [PreserveSig]
        HRESULT CopyCaptureFile(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpwstrOld, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpwstrNew, /* [in] */ int fAllowEscAbort, /* [in] */ IAMCopyCaptureFileProgress pCallback);
    }
}
