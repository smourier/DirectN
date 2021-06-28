// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmp.h(6781,5)
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
