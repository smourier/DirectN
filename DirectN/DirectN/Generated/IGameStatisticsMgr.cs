// generated from <Windows SDK Path>\um\gameux.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("aff3ea11-e70e-407d-95dd-35e612c41ce2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGameStatisticsMgr
    {
        [PreserveSig]
        HRESULT GetGameStatistics(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string GDFBinaryPath, /* [in] */ GAMESTATS_OPEN_TYPE openType, /* [out] __RPC__out */ out GAMESTATS_OPEN_RESULT pOpenResult, /* [retval][out] __RPC__deref_out_opt */ out IGameStatistics ppiStats);
        
        [PreserveSig]
        HRESULT RemoveGameStatistics(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string GDFBinaryPath);
    }
}
