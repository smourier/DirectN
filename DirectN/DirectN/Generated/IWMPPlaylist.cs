// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(2099,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d5f0f4f1-130c-11d3-b14e-00c04f79faa6"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPPlaylist
    {
        [PreserveSig]
        HRESULT get_count(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT get_name(/* [retval][out] */ out IntPtr pbstrName);
        
        [PreserveSig]
        HRESULT put_name(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName);
        
        [PreserveSig]
        HRESULT get_attributeCount(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT get_attributeName(/* [in] */ int lIndex, /* [retval][out] */ out IntPtr pbstrAttributeName);
        
        [PreserveSig]
        HRESULT get_item(int lIndex, /* [retval][out] */ out IWMPMedia ppIWMPMedia);
        
        [PreserveSig]
        HRESULT getItemInfo(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName, /* [retval][out] */ out IntPtr pbstrVal);
        
        [PreserveSig]
        HRESULT setItemInfo(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrValue);
        
        [PreserveSig]
        HRESULT get_isIdentical(/* [in] */ IWMPPlaylist pIWMPPlaylist, /* [retval][out] */ out bool pvbool);
        
        [PreserveSig]
        HRESULT clear();
        
        [PreserveSig]
        HRESULT insertItem(/* [in] */ int lIndex, /* [in] */ IWMPMedia pIWMPMedia);
        
        [PreserveSig]
        HRESULT appendItem(/* [in] */ IWMPMedia pIWMPMedia);
        
        [PreserveSig]
        HRESULT removeItem(/* [in] */ IWMPMedia pIWMPMedia);
        
        [PreserveSig]
        HRESULT moveItem(int lIndexOld, int lIndexNew);
    }
}
