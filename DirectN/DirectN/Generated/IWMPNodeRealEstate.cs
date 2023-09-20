// generated from <Windows SDK Path>\um\wmprealestate.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("42751198-5a50-4460-bcb4-709f8bdc8e59"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPNodeRealEstate
    {
        [PreserveSig]
        HRESULT GetDesiredSize(/* [out] */ out tagSIZE pSize);
        
        [PreserveSig]
        HRESULT SetRects(/* [in] */ ref tagRECT pSrc, /* [in] */ ref tagRECT pDest, /* [in] */ ref tagRECT pClip);
        
        [PreserveSig]
        HRESULT GetRects(/* [out] */ out tagRECT pSrc, /* [out] */ out tagRECT pDest, /* [out] */ out tagRECT pClip);
        
        [PreserveSig]
        HRESULT SetWindowless(/* [in] */ bool fWindowless);
        
        [PreserveSig]
        HRESULT GetWindowless(/* [out] */ out bool pfWindowless);
        
        [PreserveSig]
        HRESULT SetFullScreen(/* [in] */ bool fFullScreen);
        
        [PreserveSig]
        HRESULT GetFullScreen(/* [out] */ out bool pfFullScreen);
    }
}
