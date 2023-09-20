// generated from <Windows SDK Path>\um\opmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0a15159d-41c7-4456-93e1-284cd61d4e8d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOPMVideoOutput
    {
        [PreserveSig]
        HRESULT StartInitialization(/* [annotation][out] _Out_ */ out _OPM_RANDOM_NUMBER prnRandomNumber, /* [annotation][out] _Outptr_result_bytebuffer_(*pulCertificateLength) */ out IntPtr ppbCertificate, /* [annotation][out] _Out_ */ out uint pulCertificateLength);
        
        [PreserveSig]
        HRESULT FinishInitialization(/* [annotation][in] _In_ */ ref _OPM_ENCRYPTED_INITIALIZATION_PARAMETERS pParameters);
        
        [PreserveSig]
        HRESULT GetInformation(/* [annotation][in] _In_ */ ref _OPM_GET_INFO_PARAMETERS pParameters, /* [annotation][out] _Out_ */ out _OPM_REQUESTED_INFORMATION pRequestedInformation);
        
        [PreserveSig]
        HRESULT COPPCompatibleGetInformation(/* [annotation][in] _In_ */ ref _OPM_COPP_COMPATIBLE_GET_INFO_PARAMETERS pParameters, /* [annotation][out] _Out_ */ out _OPM_REQUESTED_INFORMATION pRequestedInformation);
        
        [PreserveSig]
        HRESULT Configure(/* [annotation][in] _In_ */ ref _OPM_CONFIGURE_PARAMETERS pParameters, /* [annotation][in] _In_ */ int ulAdditionalParametersSize, /* [annotation][in] _In_reads_bytes_opt_(ulAdditionalParametersSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbAdditionalParameters);
    }
}
