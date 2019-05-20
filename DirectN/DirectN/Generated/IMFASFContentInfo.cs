// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmcontainer.h(143,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b1dca5cd-d5da-4451-8e9e-db5c59914ead"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
