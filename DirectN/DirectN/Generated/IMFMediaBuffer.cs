// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfobjects.h(750,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("045fa593-8799-42b8-bc8d-8968c6453507"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaBuffer
    {
        [PreserveSig]
        HRESULT Lock(/* [annotation][out] _Outptr_result_bytebuffer_to_(*pcbMaxLength, *pcbCurrentLength) */ out IntPtr ppbBuffer, /* optional(DWORD) */ IntPtr pcbMaxLength, /* optional(DWORD) */ IntPtr pcbCurrentLength);
        
        [PreserveSig]
        HRESULT Unlock();
        
        [PreserveSig]
        HRESULT GetCurrentLength(/* [annotation][out] _Out_ */ out uint pcbCurrentLength);
        
        [PreserveSig]
        HRESULT SetCurrentLength(/* [in] */ uint cbCurrentLength);
        
        [PreserveSig]
        HRESULT GetMaxLength(/* [annotation][out] _Out_ */ out uint pcbMaxLength);
    }
}
