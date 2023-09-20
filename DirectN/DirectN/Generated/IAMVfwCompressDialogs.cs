// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d8d715a3-6e5e-11d0-b3f0-00aa003761c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
