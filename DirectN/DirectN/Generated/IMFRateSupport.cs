// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(8356,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0a9ccdbc-d797-4563-9667-94ec5d79292d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFRateSupport
    {
        [PreserveSig]
        HRESULT GetSlowestRate(/* [in] */ _MFRATE_DIRECTION eDirection, /* [in] */ bool fThin, /* [out] __RPC__out */ out float pflRate);
        
        [PreserveSig]
        HRESULT GetFastestRate(/* [in] */ _MFRATE_DIRECTION eDirection, /* [in] */ bool fThin, /* [out] __RPC__out */ out float pflRate);
        
        [PreserveSig]
        HRESULT IsRateSupported(/* [in] */ bool fThin, /* [in] */ float flRate, /* [unique][out][in] __RPC__inout_opt */ ref float pflNearestSupportedRate);
    }
}
