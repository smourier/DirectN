// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(6621,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("5c29bbe0-f87d-4c45-aa28-a70f0230ffa9"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPMetadataPicture
    {
        [PreserveSig]
        HRESULT get_mimeType(/* [retval][out] */ out IntPtr pbstrMimeType);
        
        [PreserveSig]
        HRESULT get_pictureType(/* [retval][out] */ out IntPtr pbstrPictureType);
        
        [PreserveSig]
        HRESULT get_description(/* [retval][out] */ out IntPtr pbstrDescription);
        
        [PreserveSig]
        HRESULT get_URL(/* [retval][out] */ out IntPtr pbstrURL);
    }
}
