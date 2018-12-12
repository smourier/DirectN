// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(13303,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d19f8e94-b126-4446-890c-5dcb7ad71453"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFOutputTrustAuthority
    {
        [PreserveSig]
        HRESULT GetAction(/* [annotation][out] _Out_ */ out _MFPOLICYMANAGER_ACTION pAction);
        
        [PreserveSig]
        HRESULT SetPolicy(/* [annotation][in] _In_reads_opt_(nPolicy) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IMFOutputPolicy[] ppPolicy, /* [in] */ uint nPolicy, /* optional(BYTE) */ out IntPtr ppbTicket, /* [annotation][out] _Out_opt_ */ out uint pcbTicket);
    }
}
