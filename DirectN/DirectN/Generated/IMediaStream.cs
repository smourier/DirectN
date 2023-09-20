// generated from <Windows SDK Path>\um\mmstream.h
using System;
using System.Runtime.InteropServices;
using MSPID = System.Guid;

namespace DirectN
{
    [ComImport, Guid("b502d1bd-9a57-11d0-8fde-00c04fd9189d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaStream
    {
        [PreserveSig]
        HRESULT GetMultiMediaStream(/* [out] __RPC__deref_out_opt */ out IMultiMediaStream ppMultiMediaStream);
        
        [PreserveSig]
        HRESULT GetInformation(/* [out] __RPC__out */ out MSPID pPurposeId, /* [out] __RPC__out */ out __MIDL___MIDL_itf_mmstream_0000_0000_0001 pType);
        
        [PreserveSig]
        HRESULT SetSameFormat(/* [in] __RPC__in_opt */ IMediaStream pStreamThatHasDesiredFormat, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT AllocateSample(/* [in] */ uint dwFlags, /* [out] __RPC__deref_out_opt */ out IStreamSample ppSample);
        
        [PreserveSig]
        HRESULT CreateSharedSample(/* [in] __RPC__in_opt */ IStreamSample pExistingSample, /* [in] */ uint dwFlags, /* [out] __RPC__deref_out_opt */ out IStreamSample ppNewSample);
        
        [PreserveSig]
        HRESULT SendEndOfStream(uint dwFlags);
    }
}
