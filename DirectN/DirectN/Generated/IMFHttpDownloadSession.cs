// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(18094,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("71fa9a2c-53ce-4662-a132-1a7e8cbf62db"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFHttpDownloadSession
    {
        [PreserveSig]
        HRESULT SetServer(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szServerName, /* [annotation][in] _In_ */ uint nPort);
        
        [PreserveSig]
        HRESULT CreateRequest(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szObjectName, /* [annotation][in] _In_ */ bool fBypassProxyCache, /* [annotation][in] _In_ */ bool fSecure, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string szVerb, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string szReferrer, /* [annotation][out] _COM_Outptr_ */ out IMFHttpDownloadRequest ppRequest);
        
        [PreserveSig]
        HRESULT Close();
    }
}
