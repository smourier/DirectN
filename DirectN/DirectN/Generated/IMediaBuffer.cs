// generated from <Windows SDK Path>\um\mediaobj.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("59eff8b9-938c-4a26-82f2-95cb84cdc837"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
