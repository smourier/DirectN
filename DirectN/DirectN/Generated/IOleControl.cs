// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ocidl.h(1456,5)
using System;
using System.Runtime.InteropServices;
using MSG = DirectN.tagMSG;

namespace DirectN
{
    [Guid("b196b288-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOleControl
    {
        [PreserveSig]
        HRESULT GetControlInfo(/* [out][in] __RPC__inout */ ref tagCONTROLINFO pCI);
        
        [PreserveSig]
        HRESULT OnMnemonic(/* [in] __RPC__in */ ref MSG pMsg);
        
        [PreserveSig]
        HRESULT OnAmbientPropertyChange(/* [in] */ int dispID);
        
        [PreserveSig]
        HRESULT FreezeEvents(/* [in] */ bool bFreeze);
    }
}
