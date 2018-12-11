// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(11476,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("dd578a4e-79b1-426c-bf8f-3add9072500b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPLibrary2 : IWMPLibrary
    {
        // IWMPLibrary
        [PreserveSig]
        new HRESULT get_name(/* [retval][out] */ out IntPtr pbstrName);
        
        [PreserveSig]
        new HRESULT get_type(/* [retval][out] */ out WMPLibraryType pwmplt);
        
        [PreserveSig]
        new HRESULT get_mediaCollection(/* [retval][out] */ out IWMPMediaCollection ppIWMPMediaCollection);
        
        [PreserveSig]
        new HRESULT isIdentical(/* [in] */ IWMPLibrary pIWMPLibrary, /* [retval][out] */ out bool pvbool);
        
        // IWMPLibrary2
        [PreserveSig]
        HRESULT getItemInfo(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName, /* [retval][out] */ out IntPtr pbstrVal);
    }
}
