// generated from <Windows SDK Path>\um\wmp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3614c646-3b3b-4de7-a81e-930e3f2127b3"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPErrorItem
    {
        [PreserveSig]
        HRESULT get_errorCode(/* [retval][out] */ out long phr);
        
        [PreserveSig]
        HRESULT get_errorDescription(/* [retval][out] */ out IntPtr pbstrDescription);
        
        [PreserveSig]
        HRESULT get_errorContext(/* [retval][out] */ out IntPtr pvarContext);
        
        [PreserveSig]
        HRESULT get_remedy(/* [retval][out] */ out long plRemedy);
        
        [PreserveSig]
        HRESULT get_customUrl(/* [retval][out] */ out IntPtr pbstrCustomUrl);
    }
}
