// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(7016,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("93e5a4e0-2d50-11d2-abfa-00a0c9c6e38d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ICaptureGraphBuilder2
    {
        [PreserveSig]
        HRESULT SetFiltergraph(/* [in] */ IGraphBuilder pfg);
        
        [PreserveSig]
        HRESULT GetFiltergraph(/* [annotation][out] _Out_ */ out IGraphBuilder ppfg);
        
        [PreserveSig]
        HRESULT SetOutputFileName(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pType, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpstrFile, /* [annotation][out] _Outptr_ */ out IBaseFilter ppf, /* [annotation][out] _Outptr_opt_ */ out IFileSinkFilter ppSink);
        
        [PreserveSig]
        HRESULT FindInterface(/* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCategory, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pType, /* [in] */ IBaseFilter pf, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppint);
        
        [PreserveSig]
        HRESULT RenderStream(/* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCategory, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pType, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pSource, /* [in] */ IBaseFilter pfCompressor, /* [in] */ IBaseFilter pfRenderer);
        
        [PreserveSig]
        HRESULT ControlStream(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCategory, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pType, /* [in] */ IBaseFilter pFilter, /* [annotation][in] _In_opt_ */ ref long pstart, /* [annotation][in] _In_opt_ */ ref long pstop, /* [in] */ ushort wStartCookie, /* [in] */ ushort wStopCookie);
        
        [PreserveSig]
        HRESULT AllocCapFile(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpstr, /* [in] */ ulong dwlSize);
        
        [PreserveSig]
        HRESULT CopyCaptureFile(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpwstrOld, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpwstrNew, /* [in] */ int fAllowEscAbort, /* [in] */ IAMCopyCaptureFileProgress pCallback);
        
        [PreserveSig]
        HRESULT FindPin(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pSource, /* [in] */ _PinDirection pindir, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCategory, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pType, /* [in] */ bool fUnconnected, /* [in] */ int num, /* [annotation][out] _Out_ */ out IPin ppPin);
    }
}
