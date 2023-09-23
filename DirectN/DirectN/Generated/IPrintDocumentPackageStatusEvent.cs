// generated from <Windows SDK Path>\um\documenttarget.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ed90c8ad-5c34-4d05-a1ec-0e8a9b3ad7af"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IPrintDocumentPackageStatusEvent
    {
        [PreserveSig]
        HRESULT PackageStatusUpdated(/* [in] __RPC__in */ ref __MIDL___MIDL_itf_documenttarget_0000_0002_0001 packageStatus);
    }
}
