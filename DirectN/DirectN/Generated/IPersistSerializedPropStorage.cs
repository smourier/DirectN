// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(3758,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e318ad57-0aa0-450f-aca5-6fab7103d917"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPersistSerializedPropStorage
    {
        [PreserveSig]
        HRESULT SetFlags(/* [in] */ int flags);
        
        [PreserveSig]
        HRESULT SetPropertyStorage(/* [annotation][in] _In_reads_bytes_(cb) */ IntPtr psps, /* [annotation][in] _In_ */ uint cb);
        
        [PreserveSig]
        HRESULT GetPropertyStorage(/* [annotation][out] _Outptr_result_bytebuffer_(*pcb) */ out tagSERIALIZEDPROPSTORAGE[] ppsps, /* [annotation][out] _Out_ */ out uint pcb);
    }
}
