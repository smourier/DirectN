// generated from <Windows SDK Path>\um\wmcontainer.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b1dca5cd-d5da-4451-8e9e-db5c59914ead"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFASFContentInfo
    {
        [PreserveSig]
        HRESULT GetHeaderSize(/* [in] */ IMFMediaBuffer pIStartOfContent, /* [out] */ out ulong cbHeaderSize);
        
        [PreserveSig]
        HRESULT ParseHeader(/* [in] */ IMFMediaBuffer pIHeaderBuffer, /* [in] */ ulong cbOffsetWithinHeader);
        
        [PreserveSig]
        HRESULT GenerateHeader(/* [out][in] */ ref IMFMediaBuffer pIHeader, /* [out] */ out uint pcbHeader);
        
        [PreserveSig]
        HRESULT GetProfile(/* [out] */ out IMFASFProfile ppIProfile);
        
        [PreserveSig]
        HRESULT SetProfile(/* [in] */ IMFASFProfile pIProfile);
        
        [PreserveSig]
        HRESULT GeneratePresentationDescriptor(/* [out] */ out IMFPresentationDescriptor ppIPresentationDescriptor);
        
        [PreserveSig]
        HRESULT GetEncodingConfigurationPropertyStore(/* [in] */ ushort wStreamNumber, /* [out] */ out IntPtr ppIStore);
    }
}
