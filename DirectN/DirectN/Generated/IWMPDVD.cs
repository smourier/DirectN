// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmp.h(5408,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8da61686-4668-4a5c-ae5d-803193293dbe"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPDVD
    {
        [PreserveSig]
        HRESULT get_isAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItem, /* [retval][out] */ out bool pIsAvailable);
        
        [PreserveSig]
        HRESULT get_domain(/* [retval][out] */ out IntPtr strDomain);
        
        [PreserveSig]
        HRESULT topMenu();
        
        [PreserveSig]
        HRESULT titleMenu();
        
        [PreserveSig]
        HRESULT back();
        
        [PreserveSig]
        HRESULT resume();
    }
}
