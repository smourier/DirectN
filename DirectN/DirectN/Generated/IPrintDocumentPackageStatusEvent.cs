// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\documenttarget.h(280,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ed90c8ad-5c34-4d05-a1ec-0e8a9b3ad7af"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IPrintDocumentPackageStatusEvent
    {
        [PreserveSig]
        HRESULT PackageStatusUpdated(/* [in] __RPC__in */ ref __MIDL___MIDL_itf_documenttarget_0000_0001_0001 packageStatus);
    }
}
