// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmcontainer.h(2548,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3d1ff0ea-679a-4190-8d46-7fa69e8c7e15"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFDRMNetHelper
    {
        [PreserveSig]
        HRESULT ProcessLicenseRequest(/* [size_is][in] __RPC__in_ecount_full(cbLicenseRequest) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pLicenseRequest, /* [in] */ int cbLicenseRequest, /* optional(BYTE) */ out IntPtr ppLicenseResponse, /* [out] __RPC__out */ out uint pcbLicenseResponse, /* [out] __RPC__deref_out_opt */ out IntPtr pbstrKID);
        
        [PreserveSig]
        HRESULT GetChainedLicenseResponse(/* optional(BYTE) */ out IntPtr ppLicenseResponse, /* [out] __RPC__out */ out uint pcbLicenseResponse);
    }
}
