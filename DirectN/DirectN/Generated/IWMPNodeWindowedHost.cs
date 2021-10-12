// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmprealestate.h(512,5)
using System;
using System.Runtime.InteropServices;
using LRESULT = System.Int64;

namespace DirectN
{
    [ComImport, Guid("a300415a-54aa-4081-adbf-3b13610d8958"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPNodeWindowedHost
    {
        [PreserveSig]
        HRESULT OnWindowMessageFromRenderer(/* [in] */ uint uMsg, /* [in] */ ulong wparam, /* [in] */ long lparam, /* [out] */ out LRESULT plRet, /* [out] */ out bool pfHandled);
    }
}
