// generated from <Windows SDK Path>\um\gameux.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("86874aa7-a1ed-450d-a7eb-b89e20b2fff3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGameExplorer2
    {
        [PreserveSig]
        HRESULT InstallGame(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string binaryGDFPath, /* [unique][in] __RPC__in_opt */ [MarshalAs(UnmanagedType.LPWStr)] string installDirectory, /* [in] */ GAME_INSTALL_SCOPE installScope);
        
        [PreserveSig]
        HRESULT UninstallGame(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string binaryGDFPath);
        
        [PreserveSig]
        HRESULT CheckAccess(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string binaryGDFPath, /* [retval][out] __RPC__out */ out bool pHasAccess);
    }
}
