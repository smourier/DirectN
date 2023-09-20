// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5b87ef6a-7ed8-434f-ba0e-184fac1628d1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFNetCredential
    {
        [PreserveSig]
        HRESULT SetUser(/* [annotation][size_is][in] _In_reads_bytes_(cbData) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbData, /* [in] */ int cbData, /* [in] */ bool fDataIsEncrypted);
        
        [PreserveSig]
        HRESULT SetPassword(/* [annotation][size_is][in] _In_reads_bytes_(cbData) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbData, /* [in] */ int cbData, /* [in] */ bool fDataIsEncrypted);
        
        [PreserveSig]
        HRESULT GetUser(/* [annotation][size_is][out] _Out_writes_to_opt_(*pcbData,*pcbData) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbData, /* [annotation][out][in] _Inout_ */ ref int pcbData, /* [in] */ bool fEncryptData);
        
        [PreserveSig]
        HRESULT GetPassword(/* [annotation][size_is][out] _Out_writes_to_opt_(*pcbData,*pcbData) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbData, /* [annotation][out][in] _Inout_ */ ref int pcbData, /* [in] */ bool fEncryptData);
        
        [PreserveSig]
        HRESULT LoggedOnUser(/* [annotation][out] _Out_ */ out bool pfLoggedOnUser);
    }
}
