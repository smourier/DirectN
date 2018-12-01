// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(1642,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fa99388a-4383-415a-a930-dd472a8cf6f7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTopologyServiceLookupClient
    {
        [PreserveSig]
        HRESULT InitServicePointers(/* [annotation][in] _In_ */ IMFTopologyServiceLookup pLookup);
        
        [PreserveSig]
        HRESULT ReleaseServicePointers();
    }
}
