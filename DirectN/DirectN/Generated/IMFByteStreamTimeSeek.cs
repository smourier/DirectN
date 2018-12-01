// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(11023,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("64976bfa-fb61-4041-9069-8c9a5f659beb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFByteStreamTimeSeek
    {
        [PreserveSig]
        HRESULT IsTimeSeekSupported(/* [out] __RPC__out */ out bool pfTimeSeekIsSupported);
        
        [PreserveSig]
        HRESULT TimeSeek(/* [in] */ ulong qwTimePosition);
        
        [PreserveSig]
        HRESULT GetTimeSeekResult(/* [out] __RPC__out */ out ulong pqwStartTime, /* [out] __RPC__out */ out ulong pqwStopTime, /* [out] __RPC__out */ out ulong pqwDuration);
    }
}
