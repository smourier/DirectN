// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(14019,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f28c0300-9baa-4477-a846-1744d9cbf533"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderPlaylistBurn
    {
        [PreserveSig]
        HRESULT InitPlaylistBurn(/* [in] */ uint cFiles, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string ppwszFilenames, /* [in] */ IWMStatusCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pvContext);
        
        [PreserveSig]
        HRESULT GetInitResults(/* [in] */ uint cFiles, /* [out] */ out HRESULT phrStati);
        
        [PreserveSig]
        HRESULT Cancel();
        
        [PreserveSig]
        HRESULT EndPlaylistBurn(/* [in] */ HRESULT hrBurnResult);
    }
}
