// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmprealestate.h(572,5)
using System;
using System.Runtime.InteropServices;
using LRESULT = System.Int64;

namespace DirectN
{
    [Guid("3a0daa30-908d-4789-ba87-aed879b5c49b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPWindowMessageSink
    {
        [PreserveSig]
        HRESULT OnWindowMessage(uint uMsg, ulong wparam, long lparam, ref LRESULT plRet, ref bool pfHandled);
    }
}
