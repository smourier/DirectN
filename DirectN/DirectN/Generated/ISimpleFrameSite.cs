// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ocidl.h(2933,5)
using System;
using System.Runtime.InteropServices;
using LRESULT = System.Int64;

namespace DirectN
{
    [ComImport, Guid("742b0e01-14e6-101b-914e-00aa00300cab"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISimpleFrameSite
    {
        [PreserveSig]
        HRESULT PreMessageFilter(/* [in] __RPC__in */ IntPtr hWnd, /* [in] */ uint msg, /* [in] */ ulong wp, /* [in] */ long lp, /* [out] __RPC__out */ out LRESULT plResult, /* [out] __RPC__out */ out uint pdwCookie);
        
        [PreserveSig]
        HRESULT PostMessageFilter(/* [in] __RPC__in */ IntPtr hWnd, /* [in] */ uint msg, /* [in] */ ulong wp, /* [in] */ long lp, /* [out] __RPC__out */ out LRESULT plResult, /* [in] */ uint dwCookie);
    }
}
