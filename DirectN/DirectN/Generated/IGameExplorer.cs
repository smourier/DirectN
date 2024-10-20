// generated from <Windows SDK Path>\um\gameux.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e7b2fb72-d728-49b3-a5f2-18ebf5f1349e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGameExplorer
    {
        [PreserveSig]
        HRESULT AddGame(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.BStr)] string bstrGDFBinaryPath, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.BStr)] string bstrGameInstallDirectory, /* [in] */ GAME_INSTALL_SCOPE installScope, /* [out][in] __RPC__inout */ out Guid pguidInstanceID);
        
        [PreserveSig]
        HRESULT RemoveGame(/* [in] */ Guid guidInstanceID);
        
        [PreserveSig]
        HRESULT UpdateGame(/* [in] */ Guid guidInstanceID);
        
        [PreserveSig]
        HRESULT VerifyAccess(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.BStr)] string bstrGDFBinaryPath, /* [out] __RPC__out */ out bool pfHasAccess);
    }
}
