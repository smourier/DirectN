// generated from <Windows SDK Path>\um\ocidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("55980ba0-35aa-11cf-b671-00aa004cd6d8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPointerInactive
    {
        [PreserveSig]
        HRESULT GetActivationPolicy(/* [out] __RPC__out */ out uint pdwPolicy);
        
        [PreserveSig]
        HRESULT OnInactiveMouseMove(/* [in] __RPC__in */ ref tagRECT pRectBounds, /* [in] */ int x, /* [in] */ int y, /* [in] */ uint grfKeyState);
        
        [PreserveSig]
        HRESULT OnInactiveSetCursor(/* [in] __RPC__in */ ref tagRECT pRectBounds, /* [in] */ int x, /* [in] */ int y, /* [in] */ uint dwMouseMsg, /* [in] */ bool fSetAlways);
    }
}
