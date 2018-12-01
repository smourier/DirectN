// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(6715,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bf87b6e0-8c27-11d0-b3f0-00aa003761c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ICaptureGraphBuilder
    {
        [PreserveSig]
        HRESULT SetFiltergraph(/* [in] */ IGraphBuilder pfg);
        
        [PreserveSig]
        HRESULT GetFiltergraph(/* [annotation][out] _Out_ */ out IGraphBuilder ppfg);
        
        [PreserveSig]
        HRESULT SetOutputFileName(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pType, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpstrFile, /* [annotation][out] _Out_ */ out IBaseFilter ppf, /* [annotation][out] _Out_ */ out IFileSinkFilter ppSink);
        
        [PreserveSig]
        HRESULT FindInterface(/* [annotation][unique][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCategory, /* [in] */ IBaseFilter pf, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppint);
        
        [PreserveSig]
        HRESULT RenderStream(/* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCategory, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pSource, /* [in] */ IBaseFilter pfCompressor, /* [in] */ IBaseFilter pfRenderer);
        
        [PreserveSig]
        HRESULT ControlStream(/* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCategory, /* [in] */ IBaseFilter pFilter, /* [in] */ ref long pstart, /* [in] */ ref long pstop, /* [in] */ ushort wStartCookie, /* [in] */ ushort wStopCookie);
        
        [PreserveSig]
        HRESULT AllocCapFile(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpstr, /* [in] */ ulong dwlSize);
        
        [PreserveSig]
        HRESULT CopyCaptureFile(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpwstrOld, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpwstrNew, /* [in] */ int fAllowEscAbort, /* [in] */ IAMCopyCaptureFileProgress pCallback);
    }
}
