// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmprealestate.h(1016,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("959506c1-0314-4ec5-9e61-8528db5e5478"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPRenderConfig
    {
        [PreserveSig]
        HRESULT put_inProcOnly(/* [in] */ bool fInProc);
        
        [PreserveSig]
        HRESULT get_inProcOnly(/* [out] */ out bool pfInProc);
    }
}
