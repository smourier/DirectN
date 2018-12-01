// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(9406,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d8d715a0-6e5e-11d0-b3f0-00aa003761c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMVfwCaptureDialogs
    {
        [PreserveSig]
        HRESULT HasDialog(/* [in] */ int iDialog);
        
        [PreserveSig]
        HRESULT ShowDialog(/* [in] */ int iDialog, /* [in] */ IntPtr hwnd);
        
        [PreserveSig]
        HRESULT SendDriverMessage(/* [in] */ int iDialog, /* [in] */ int uMsg, /* [in] */ int dw1, /* [in] */ int dw2);
    }
}
