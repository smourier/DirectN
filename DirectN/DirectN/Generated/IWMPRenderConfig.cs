// generated from <Windows SDK Path>\um\wmprealestate.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("959506c1-0314-4ec5-9e61-8528db5e5478"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPRenderConfig
    {
        [PreserveSig]
        HRESULT put_inProcOnly(/* [in] */ bool fInProc);
        
        [PreserveSig]
        HRESULT get_inProcOnly(/* [out] */ out bool pfInProc);
    }
}
