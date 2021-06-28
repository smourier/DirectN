// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmprealestate.h(670,5)
using System;
using System.Runtime.InteropServices;
using LRESULT = System.Int64;

namespace DirectN
{
    [ComImport, Guid("9b9199ad-780c-4eda-b816-261eba5d1575"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPNodeWindowless : IWMPWindowMessageSink
    {
        // IWMPWindowMessageSink
        [PreserveSig]
        new HRESULT OnWindowMessage(uint uMsg, ulong wparam, long lparam, ref LRESULT plRet, ref bool pfHandled);
        
        // IWMPNodeWindowless
        [PreserveSig]
        HRESULT OnDraw(/* [in] */ long hdc, /* [in] */ ref tagRECT prcDraw);
    }
}
