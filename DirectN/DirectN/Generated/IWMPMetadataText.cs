// generated from <Windows SDK Path>\um\wmp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("769a72db-13d2-45e2-9c48-53ca9d5b7450"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPMetadataText
    {
        [PreserveSig]
        HRESULT get_description(/* [retval][out] */ out IntPtr pbstrDescription);
        
        [PreserveSig]
        HRESULT get_text(/* [retval][out] */ out IntPtr pbstrText);
    }
}
