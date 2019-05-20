// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmp.h(6254,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f75ccec0-c67c-475c-931e-8719870bee7d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPErrorItem2 : IWMPErrorItem
    {
        // IWMPErrorItem
        [PreserveSig]
        new HRESULT get_errorCode(/* [retval][out] */ out long phr);
        
        [PreserveSig]
        new HRESULT get_errorDescription(/* [retval][out] */ out IntPtr pbstrDescription);
        
        [PreserveSig]
        new HRESULT get_errorContext(/* [retval][out] */ out IntPtr pvarContext);
        
        [PreserveSig]
        new HRESULT get_remedy(/* [retval][out] */ out long plRemedy);
        
        [PreserveSig]
        new HRESULT get_customUrl(/* [retval][out] */ out IntPtr pbstrCustomUrl);
        
        // IWMPErrorItem2
        [PreserveSig]
        HRESULT get_condition(/* [retval][out] */ out long plCondition);
    }
}
