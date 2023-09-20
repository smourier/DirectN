// generated from <Windows SDK Path>\um\dshowasf.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("45086030-f7e4-486a-b504-826bb5792a3b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IConfigAsfWriter
    {
        [PreserveSig]
        HRESULT ConfigureFilterUsingProfileId(/* [in] */ uint dwProfileId);
        
        [PreserveSig]
        HRESULT GetCurrentProfileId(/* [out] __RPC__out */ out uint pdwProfileId);
        
        [PreserveSig]
        HRESULT ConfigureFilterUsingProfileGuid(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidProfile);
        
        [PreserveSig]
        HRESULT GetCurrentProfileGuid(/* [out] __RPC__out */ out Guid pProfileGuid);
        
        [PreserveSig]
        HRESULT ConfigureFilterUsingProfile(/* [in] __RPC__in_opt */ IWMProfile pProfile);
        
        [PreserveSig]
        HRESULT GetCurrentProfile(/* [out] __RPC__deref_out_opt */ out IWMProfile ppProfile);
        
        [PreserveSig]
        HRESULT SetIndexMode(/* [in] */ bool bIndexFile);
        
        [PreserveSig]
        HRESULT GetIndexMode(/* [out] __RPC__out */ out bool pbIndexFile);
    }
}
