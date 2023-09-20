// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7ec4b1bd-43fb-4763-85d2-64fcb5c5f4cb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFContentDecryptorContext
    {
        [PreserveSig]
        HRESULT InitializeHardwareKey(/* [annotation][in] _In_ */ uint InputPrivateDataByteCount, /* optional(void) */ IntPtr InputPrivateData, /* [annotation][out] _Out_ */ out ulong OutputPrivateData);
    }
}
