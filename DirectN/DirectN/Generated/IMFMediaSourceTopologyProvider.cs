// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0e1d6009-c9f3-442d-8c51-a42d2d49452f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSourceTopologyProvider
    {
        [PreserveSig]
        HRESULT GetMediaSourceTopology(/* [in] __RPC__in_opt */ IMFPresentationDescriptor pPresentationDescriptor, /* [out] __RPC__deref_out_opt */ out IMFTopology ppTopology);
    }
}
