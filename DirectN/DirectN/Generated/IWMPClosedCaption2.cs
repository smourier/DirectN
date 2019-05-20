// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmp.h(7873,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("350ba78b-6bc8-4113-a5f5-312056934eb6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPClosedCaption2 : IWMPClosedCaption
    {
        // IWMPClosedCaption
        [PreserveSig]
        new HRESULT get_SAMIStyle(/* [retval][out] */ out IntPtr pbstrSAMIStyle);
        
        [PreserveSig]
        new HRESULT put_SAMIStyle(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrSAMIStyle);
        
        [PreserveSig]
        new HRESULT get_SAMILang(/* [retval][out] */ out IntPtr pbstrSAMILang);
        
        [PreserveSig]
        new HRESULT put_SAMILang(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrSAMILang);
        
        [PreserveSig]
        new HRESULT get_SAMIFileName(/* [retval][out] */ out IntPtr pbstrSAMIFileName);
        
        [PreserveSig]
        new HRESULT put_SAMIFileName(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrSAMIFileName);
        
        [PreserveSig]
        new HRESULT get_captioningId(/* [retval][out] */ out IntPtr pbstrCaptioningID);
        
        [PreserveSig]
        new HRESULT put_captioningId(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrCaptioningID);
        
        // IWMPClosedCaption2
        [PreserveSig]
        HRESULT get_SAMILangCount(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT getSAMILangName(/* [in] */ int nIndex, /* [retval][out] */ out IntPtr pbstrName);
        
        [PreserveSig]
        HRESULT getSAMILangID(/* [in] */ int nIndex, /* [retval][out] */ out long plLangID);
        
        [PreserveSig]
        HRESULT get_SAMIStyleCount(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT getSAMIStyleName(/* [in] */ int nIndex, /* [retval][out] */ out IntPtr pbstrName);
    }
}
