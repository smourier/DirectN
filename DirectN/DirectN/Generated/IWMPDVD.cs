// generated from <Windows SDK Path>\um\wmp.h
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
