// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1b4cf4b9-3a16-4115-839d-03cc5c99df01"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFHttpDownloadSessionProvider
    {
        [PreserveSig]
        HRESULT CreateHttpDownloadSession(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wszScheme, /* [annotation][out] _COM_Outptr_ */ out IMFHttpDownloadSession ppDownloadSession);
    }
}
