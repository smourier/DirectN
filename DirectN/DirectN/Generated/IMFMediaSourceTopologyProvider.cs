// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(11283,5)
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
