// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(3870,5)
using System;
using System.Runtime.InteropServices;
using SERIALIZEDPROPSTORAGE = DirectN.tagSERIALIZEDPROPSTORAGE;

namespace DirectN
{
    [Guid("77effa68-4f98-4366-ba72-573b3d880571"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPersistSerializedPropStorage2 : IPersistSerializedPropStorage
    {
        // IPersistSerializedPropStorage
        [PreserveSig]
        new HRESULT SetFlags(/* [in] */ int flags);
        
        [PreserveSig]
        new HRESULT SetPropertyStorage(/* [annotation][in] _In_reads_bytes_(cb) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] PCUSERIALIZEDPROPSTORAGE[] psps, /* [annotation][in] _In_ */ uint cb);
        
        [PreserveSig]
        new HRESULT GetPropertyStorage(/* [annotation][out] _Outptr_result_bytebuffer_(*pcb) */ out IntPtr ppsps, /* [annotation][out] _Out_ */ out uint pcb);
        
        // IPersistSerializedPropStorage2
        [PreserveSig]
        HRESULT GetPropertyStorageSize(/* [annotation][out] _Out_ */ out uint pcb);
        
        [PreserveSig]
        HRESULT GetPropertyStorageBuffer(/* [annotation][out] _Out_writes_bytes_to_(cb, *pcbWritten) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] SERIALIZEDPROPSTORAGE[] psps, /* [in] */ uint cb, /* [annotation][out] _Out_ */ out uint pcbWritten);
    }
}
