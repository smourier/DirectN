// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(17337,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7ec4b1bd-43fb-4763-85d2-64fcb5c5f4cb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFContentDecryptorContext
    {
        [PreserveSig]
        HRESULT InitializeHardwareKey(/* [annotation][in] _In_ */ uint InputPrivateDataByteCount, /* [annotation][in] _In_reads_opt_(InputPrivateDataByteCount) */ out IntPtr InputPrivateData, /* [annotation][out] _Out_ */ out ulong OutputPrivateData);
    }
}
