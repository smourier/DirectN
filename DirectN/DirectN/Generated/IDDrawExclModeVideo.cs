// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("153acc21-d83b-11d1-82bf-00a0c9696c8f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDDrawExclModeVideo
    {
        [PreserveSig]
        HRESULT SetDDrawObject(/* [in] */ IDirectDraw pDDrawObject);
        
        [PreserveSig]
        HRESULT GetDDrawObject(/* [annotation][out] _Out_ */ out IDirectDraw ppDDrawObject, /* [annotation][out] _Out_ */ out bool pbUsingExternal);
        
        [PreserveSig]
        HRESULT SetDDrawSurface(/* [in] */ IDirectDrawSurface pDDrawSurface);
        
        [PreserveSig]
        HRESULT GetDDrawSurface(/* [annotation][out] _Out_ */ out IDirectDrawSurface ppDDrawSurface, /* [annotation][out] _Out_ */ out bool pbUsingExternal);
        
        [PreserveSig]
        HRESULT SetDrawParameters(/* [in] */ ref tagRECT prcSource, /* [in] */ ref tagRECT prcTarget);
        
        [PreserveSig]
        HRESULT GetNativeVideoProps(/* [annotation][out] _Out_ */ out uint pdwVideoWidth, /* [annotation][out] _Out_ */ out uint pdwVideoHeight, /* [annotation][out] _Out_ */ out uint pdwPictAspectRatioX, /* [annotation][out] _Out_ */ out uint pdwPictAspectRatioY);
        
        [PreserveSig]
        HRESULT SetCallbackInterface(/* [in] */ IDDrawExclModeVideoCallback pCallback, /* [in] */ uint dwFlags);
    }
}
