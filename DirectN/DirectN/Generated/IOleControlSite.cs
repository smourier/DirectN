// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(1586,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b196b289-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOleControlSite
    {
        [PreserveSig]
        HRESULT OnControlInfoChanged();
        
        [PreserveSig]
        HRESULT LockInPlaceActive(/* [in] */ bool fLock);
        
        [PreserveSig]
        HRESULT GetExtendedControl(/* [out] __RPC__deref_out_opt */ out IDispatch ppDisp);
        
        [PreserveSig]
        HRESULT TransformCoords(/* [out][in] __RPC__inout */ ref _POINTL pPtlHimetric, /* [out][in] __RPC__inout */ ref tagPOINTF pPtfContainer, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT TranslateAcceleratorA(/* [in] __RPC__in */ ref tagMSG pMsg, /* [in] */ uint grfModifiers);
        
        [PreserveSig]
        HRESULT OnFocus(/* [in] */ bool fGotFocus);
        
        [PreserveSig]
        HRESULT ShowPropertyFrame();
    }
}
