// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmp.h(5260,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ab7c88bb-143e-4ea4-acc3-e4350b2106c3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPMedia2 : IWMPMedia
    {
        // IWMPMedia
        [PreserveSig]
        new HRESULT get_isIdentical(/* [in] */ IWMPMedia pIWMPMedia, /* [retval][out] */ out bool pvbool);
        
        [PreserveSig]
        new HRESULT get_sourceURL(/* [retval][out] */ out IntPtr pbstrSourceURL);
        
        [PreserveSig]
        new HRESULT get_name(/* [retval][out] */ out IntPtr pbstrName);
        
        [PreserveSig]
        new HRESULT put_name(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName);
        
        [PreserveSig]
        new HRESULT get_imageSourceWidth(/* [retval][out] */ out long pWidth);
        
        [PreserveSig]
        new HRESULT get_imageSourceHeight(/* [retval][out] */ out long pHeight);
        
        [PreserveSig]
        new HRESULT get_markerCount(/* [retval][out] */ out long pMarkerCount);
        
        [PreserveSig]
        new HRESULT getMarkerTime(/* [in] */ int MarkerNum, /* [retval][out] */ out double pMarkerTime);
        
        [PreserveSig]
        new HRESULT getMarkerName(/* [in] */ int MarkerNum, /* [retval][out] */ out IntPtr pbstrMarkerName);
        
        [PreserveSig]
        new HRESULT get_duration(/* [retval][out] */ out double pDuration);
        
        [PreserveSig]
        new HRESULT get_durationString(/* [retval][out] */ out IntPtr pbstrDuration);
        
        [PreserveSig]
        new HRESULT get_attributeCount(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        new HRESULT getAttributeName(/* [in] */ int lIndex, /* [retval][out] */ out IntPtr pbstrItemName);
        
        [PreserveSig]
        new HRESULT getItemInfo(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName, /* [retval][out] */ out IntPtr pbstrVal);
        
        [PreserveSig]
        new HRESULT setItemInfo(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrVal);
        
        [PreserveSig]
        new HRESULT getItemInfoByAtom(/* [in] */ int lAtom, /* [retval][out] */ out IntPtr pbstrVal);
        
        [PreserveSig]
        new HRESULT isMemberOf(/* [in] */ IWMPPlaylist pPlaylist, /* [retval][out] */ out bool pvarfIsMemberOf);
        
        [PreserveSig]
        new HRESULT isReadOnlyItem(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName, /* [retval][out] */ out bool pvarfIsReadOnly);
        
        // IWMPMedia2
        [PreserveSig]
        HRESULT get_error(/* [retval][out] */ out IWMPErrorItem ppIWMPErrorItem);
    }
}
