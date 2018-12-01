// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mediaobj.h(184,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("59eff8b9-938c-4a26-82f2-95cb84cdc837"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaBuffer
    {
        [PreserveSig]
        HRESULT SetLength(uint cbLength);
        
        [PreserveSig]
        HRESULT GetMaxLength(/* [annotation][out] _Out_ */ out uint pcbMaxLength);
        
        [PreserveSig]
        HRESULT GetBufferAndLength(/* [annotation][out] _Outptr_opt_result_bytebuffer_(*pcbLength) */ out byte[] ppBuffer, /* [annotation][out] _Out_opt_ */ out uint pcbLength);
    }
}
