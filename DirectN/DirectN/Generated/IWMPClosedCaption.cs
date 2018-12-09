// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(1899,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4f2df574-c588-11d3-9ed0-00c04fb6e937"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPClosedCaption
    {
        [PreserveSig]
        HRESULT get_SAMIStyle(/* [retval][out] */ out IntPtr pbstrSAMIStyle);
        
        [PreserveSig]
        HRESULT put_SAMIStyle(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrSAMIStyle);
        
        [PreserveSig]
        HRESULT get_SAMILang(/* [retval][out] */ out IntPtr pbstrSAMILang);
        
        [PreserveSig]
        HRESULT put_SAMILang(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrSAMILang);
        
        [PreserveSig]
        HRESULT get_SAMIFileName(/* [retval][out] */ out IntPtr pbstrSAMIFileName);
        
        [PreserveSig]
        HRESULT put_SAMIFileName(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrSAMIFileName);
        
        [PreserveSig]
        HRESULT get_captioningId(/* [retval][out] */ out IntPtr pbstrCaptioningID);
        
        [PreserveSig]
        HRESULT put_captioningId(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrCaptioningID);
    }
}
