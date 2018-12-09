// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmcodecdsp.h(2523,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("57665d4c-0414-4faa-905b-10e546f81c33"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMResizerProps
    {
        [PreserveSig]
        HRESULT SetResizerQuality(/* [in] */ int lquality);
        
        [PreserveSig]
        HRESULT SetInterlaceMode(/* [in] */ int lmode);
        
        [PreserveSig]
        HRESULT SetClipRegion(/* [in] */ int lClipOriXSrc, /* [in] */ int lClipOriYSrc, /* [in] */ int lClipWidthSrc, /* [in] */ int lClipHeightSrc);
        
        [PreserveSig]
        HRESULT SetFullCropRegion(/* [in] */ int lClipOriXSrc, /* [in] */ int lClipOriYSrc, /* [in] */ int lClipWidthSrc, /* [in] */ int lClipHeightSrc, /* [in] */ int lClipOriXDst, /* [in] */ int lClipOriYDst, /* [in] */ int lClipWidthDst, /* [in] */ int lClipHeightDst);
        
        [PreserveSig]
        HRESULT GetFullCropRegion(/* [out] */ out int lClipOriXSrc, /* [out] */ out int lClipOriYSrc, /* [out] */ out int lClipWidthSrc, /* [out] */ out int lClipHeightSrc, /* [out] */ out int lClipOriXDst, /* [out] */ out int lClipOriYDst, /* [out] */ out int lClipWidthDst, /* [out] */ out int lClipHeightDst);
    }
}
