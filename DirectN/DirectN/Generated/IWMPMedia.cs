// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(957,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("94d55e95-3fac-11d3-b155-00c04f79faa6"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPMedia
    {
        [PreserveSig]
        HRESULT get_isIdentical(/* [in] */ IWMPMedia pIWMPMedia, /* [retval][out] */ out bool pvbool);
        
        [PreserveSig]
        HRESULT get_sourceURL(/* [retval][out] */ out IntPtr pbstrSourceURL);
        
        [PreserveSig]
        HRESULT get_name(/* [retval][out] */ out IntPtr pbstrName);
        
        [PreserveSig]
        HRESULT put_name(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName);
        
        [PreserveSig]
        HRESULT get_imageSourceWidth(/* [retval][out] */ out long pWidth);
        
        [PreserveSig]
        HRESULT get_imageSourceHeight(/* [retval][out] */ out long pHeight);
        
        [PreserveSig]
        HRESULT get_markerCount(/* [retval][out] */ out long pMarkerCount);
        
        [PreserveSig]
        HRESULT getMarkerTime(/* [in] */ int MarkerNum, /* [retval][out] */ out double pMarkerTime);
        
        [PreserveSig]
        HRESULT getMarkerName(/* [in] */ int MarkerNum, /* [retval][out] */ out IntPtr pbstrMarkerName);
        
        [PreserveSig]
        HRESULT get_duration(/* [retval][out] */ out double pDuration);
        
        [PreserveSig]
        HRESULT get_durationString(/* [retval][out] */ out IntPtr pbstrDuration);
        
        [PreserveSig]
        HRESULT get_attributeCount(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT getAttributeName(/* [in] */ int lIndex, /* [retval][out] */ out IntPtr pbstrItemName);
        
        [PreserveSig]
        HRESULT getItemInfo(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName, /* [retval][out] */ out IntPtr pbstrVal);
        
        [PreserveSig]
        HRESULT setItemInfo(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrVal);
        
        [PreserveSig]
        HRESULT getItemInfoByAtom(/* [in] */ int lAtom, /* [retval][out] */ out IntPtr pbstrVal);
        
        [PreserveSig]
        HRESULT isMemberOf(/* [in] */ IWMPPlaylist pPlaylist, /* [retval][out] */ out bool pvarfIsMemberOf);
        
        [PreserveSig]
        HRESULT isReadOnlyItem(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName, /* [retval][out] */ out bool pvarfIsReadOnly);
    }
}
