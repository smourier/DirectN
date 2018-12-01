// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(9514,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d8d715a3-6e5e-11d0-b3f0-00aa003761c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMVfwCompressDialogs
    {
        [PreserveSig]
        HRESULT ShowDialog(/* [in] */ int iDialog, /* [in] */ IntPtr hwnd);
        
        [PreserveSig]
        HRESULT GetState(/* [annotation][size_is][out] _Out_writes_bytes_to_(*pcbState, *pcbState) */ IntPtr pState, /* [annotation][out][in] _Inout_ */ ref int pcbState);
        
        [PreserveSig]
        HRESULT SetState(/* [annotation][size_is][in] _In_reads_bytes_(cbState) */ IntPtr pState, /* [in] */ int cbState);
        
        [PreserveSig]
        HRESULT SendDriverMessage(/* [in] */ int uMsg, /* [in] */ int dw1, /* [in] */ int dw2);
    }
}
