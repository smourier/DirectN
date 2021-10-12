// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(18456,5)
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
