// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmcodecdsp.h(1477,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("04a578b2-e778-422a-a805-b3ee54d90bd9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IValidateBinding
    {
        [PreserveSig]
        HRESULT GetIdentifier(/* [in] */ Guid guidLicensorID, /* [size_is][in] __RPC__in_ecount_full(cbEphemeron) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pbEphemeron, /* [in] */ int cbEphemeron, /* optional(BYTE) */ out IntPtr ppbBlobValidationID, /* [out] __RPC__out */ out uint pcbBlobSize);
    }
}
