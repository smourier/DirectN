// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(5636,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("55980ba0-35aa-11cf-b671-00aa004cd6d8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPointerInactive
    {
        [PreserveSig]
        HRESULT GetActivationPolicy(/* [out] __RPC__out */ out uint pdwPolicy);
        
        [PreserveSig]
        HRESULT OnInactiveMouseMove(/* [in] __RPC__in */ IntPtr pRectBounds, /* [in] */ int x, /* [in] */ int y, /* [in] */ uint grfKeyState);
        
        [PreserveSig]
        HRESULT OnInactiveSetCursor(/* [in] __RPC__in */ IntPtr pRectBounds, /* [in] */ int x, /* [in] */ int y, /* [in] */ uint dwMouseMsg, /* [in] */ bool fSetAlways);
    }
}
