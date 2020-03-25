// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mediaobj.h(184,5)
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
        HRESULT GetBufferAndLength(/* optional(BYTE) */ IntPtr ppBuffer, /* optional(DWORD) */ IntPtr pcbLength);
    }
}
