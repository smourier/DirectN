// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(5874,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("376bd3aa-3845-101b-84ed-08002b2ec713"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPerPropertyBrowsing
    {
        [PreserveSig]
        HRESULT GetDisplayString(/* [in] */ int dispID, /* optional(BSTR) */ out IntPtr pBstr);
        
        [PreserveSig]
        HRESULT MapPropertyToPage(/* [in] */ int dispID, /* [out] __RPC__out */ out Guid pClsid);
        
        [PreserveSig]
        HRESULT GetPredefinedStrings(/* [in] */ int dispID, /* [out] __RPC__out */ out tagCALPOLESTR pCaStringsOut, /* [out] __RPC__out */ out tagCADWORD pCaCookiesOut);
        
        [PreserveSig]
        HRESULT GetPredefinedValue(/* [in] */ int dispID, /* [in] */ uint dwCookie, /* [out] __RPC__out */ out object pVarOut);
    }
}
