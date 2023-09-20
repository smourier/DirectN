// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("38e33520-fca1-4845-a27a-68b7c6ab3789"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFExtendedCameraControl
    {
        [PreserveSig]
        ulong GetCapabilities();
        
        [PreserveSig]
        HRESULT SetFlags(/* [annotation][in] _In_ */ ulong ulFlags);
        
        [PreserveSig]
        ulong GetFlags();
        
        [PreserveSig]
        HRESULT LockPayload(/* [annotation][out] _Outptr_result_buffer_(*pulPayload) */ out IntPtr ppPayload, /* [annotation][out] _Out_ */ out uint pulPayload);
        
        [PreserveSig]
        HRESULT UnlockPayload();
        
        [PreserveSig]
        HRESULT CommitSettings();
    }
}
