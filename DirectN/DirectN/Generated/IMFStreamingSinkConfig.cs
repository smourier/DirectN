// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9db7aa41-3cc5-40d4-8509-555804ad34cc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFStreamingSinkConfig
    {
        [PreserveSig]
        HRESULT StartStreaming(/* [in] */ bool fSeekOffsetIsByteOffset, /* [in] */ ulong qwSeekOffset);
    }
}
