// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(2092,5)
using System;
using System.Runtime.InteropServices;
using MSG = DirectN.tagMSG;

namespace DirectN
{
    [Guid("b196b28c-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyPageSite
    {
        [PreserveSig]
        HRESULT OnStatusChange(/* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT GetLocaleID(/* [out] __RPC__out */ out int pLocaleID);
        
        [PreserveSig]
        HRESULT GetPageContainer(/* [out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);
        
        [PreserveSig]
        HRESULT TranslateAcceleratorA(/* [in] __RPC__in */ ref MSG pMsg);
    }
}
