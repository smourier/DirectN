// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmp.h(10572,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3df47861-7df1-4c1f-a81b-4c26f0f7a7c6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPLibrary
    {
        [PreserveSig]
        HRESULT get_name(/* [retval][out] */ out IntPtr pbstrName);
        
        [PreserveSig]
        HRESULT get_type(/* [retval][out] */ out WMPLibraryType pwmplt);
        
        [PreserveSig]
        HRESULT get_mediaCollection(/* [retval][out] */ out IWMPMediaCollection ppIWMPMediaCollection);
        
        [PreserveSig]
        HRESULT isIdentical(/* [in] */ IWMPLibrary pIWMPLibrary, /* [retval][out] */ out bool pvbool);
    }
}
