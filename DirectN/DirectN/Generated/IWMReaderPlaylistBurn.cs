// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(14961,5)
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
