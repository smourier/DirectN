// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("75510662-b034-48f4-88a7-8de61daa4af9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCameraControlDefaults
    {
        [PreserveSig]
        __MIDL___MIDL_itf_mfidl_0000_0136_0001 GetType();
        
        [PreserveSig]
        HRESULT GetRangeInfo(/* [annotation][out] _Out_ */ out __MIDL___MIDL_itf_mfidl_0000_0136_0002 rangeInfo);
        
        [PreserveSig]
        HRESULT LockControlData(/* [annotation][out] _Outptr_result_bytebuffer_(*controlSize) */ out IntPtr control, /* [annotation][out] _Out_ */ out uint controlSize, /* optional(void) */ out IntPtr data, /* optional(ULONG) */ IntPtr dataSize);
        
        [PreserveSig]
        HRESULT UnlockControlData();
    }
}
