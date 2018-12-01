// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(1742,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b196b28d-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyPage
    {
        [PreserveSig]
        HRESULT SetPageSite(/* [in] __RPC__in_opt */ IPropertyPageSite pPageSite);
        
        [PreserveSig]
        HRESULT Activate(/* [in] __RPC__in */ IntPtr hWndParent, /* [in] __RPC__in */ IntPtr pRect, /* [in] */ bool bModal);
        
        [PreserveSig]
        HRESULT Deactivate();
        
        [PreserveSig]
        HRESULT GetPageInfo(/* [out] __RPC__out */ out tagPROPPAGEINFO pPageInfo);
        
        [PreserveSig]
        HRESULT SetObjects(/* [in] */ uint cObjects, /* [size_is][in] __RPC__in_ecount_full(cObjects) */ [MarshalAs(UnmanagedType.IUnknown)] object ppUnk);
        
        [PreserveSig]
        HRESULT Show(/* [in] */ uint nCmdShow);
        
        [PreserveSig]
        HRESULT Move(/* [in] __RPC__in */ IntPtr pRect);
        
        [PreserveSig]
        HRESULT IsPageDirty();
        
        [PreserveSig]
        HRESULT Apply();
        
        [PreserveSig]
        HRESULT Help(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pszHelpDir);
        
        [PreserveSig]
        HRESULT TranslateAcceleratorA(/* [in] __RPC__in */ ref tagMSG pMsg);
    }
}
