// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2e5ea3e0-e924-11d2-b6da-00a0c995e8df"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDecimateVideoImage
    {
        [PreserveSig]
        HRESULT SetDecimationImageSize(/* [in] */ int lWidth, /* [in] */ int lHeight);
        
        [PreserveSig]
        HRESULT ResetDecimationImageSize();
    }
}
