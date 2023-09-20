// generated from <Windows SDK Path>\um\wmcodecdsp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e6a49e22-c099-421d-aad3-c061fb4ae85b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMColorConvProps
    {
        [PreserveSig]
        HRESULT SetMode(/* [in] */ int lMode);
        
        [PreserveSig]
        HRESULT SetFullCroppingParam(/* [in] */ int lSrcCropLeft, /* [in] */ int lSrcCropTop, /* [in] */ int lDstCropLeft, /* [in] */ int lDstCropTop, /* [in] */ int lCropWidth, /* [in] */ int lCropHeight);
    }
}
