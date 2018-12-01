// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(18067,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1b4cf4b9-3a16-4115-839d-03cc5c99df01"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFHttpDownloadSessionProvider
    {
        [PreserveSig]
        HRESULT CreateHttpDownloadSession(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string wszScheme, /* [annotation][out] _COM_Outptr_ */ out IMFHttpDownloadSession ppDownloadSession);
    }
}
