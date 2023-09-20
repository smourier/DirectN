// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f28c0300-9baa-4477-a846-1744d9cbf533"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderPlaylistBurn
    {
        [PreserveSig]
        HRESULT InitPlaylistBurn(/* [in] */ uint cFiles, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string ppwszFilenames, /* [in] */ IWMStatusCallback pCallback, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT GetInitResults(/* [in] */ uint cFiles, /* [out] */ out HRESULT phrStati);
        
        [PreserveSig]
        HRESULT Cancel();
        
        [PreserveSig]
        HRESULT EndPlaylistBurn(/* [in] */ HRESULT hrBurnResult);
    }
}
