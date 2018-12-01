// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(1548,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fa993889-4383-415a-a930-dd472a8cf6f7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTopologyServiceLookup
    {
        [PreserveSig]
        HRESULT LookupService(/* [in] */ _MF_SERVICE_LOOKUP_TYPE Type, /* [in] */ uint dwIndex, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidService, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _Out_writes_to_(1,*pnObjects) */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObjects, /* [annotation][out][in] _Inout_ */ ref uint pnObjects);
    }
}
