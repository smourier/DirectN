// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mmstream.h(164,5)
using System;
using System.Runtime.InteropServices;
using REFMSPID = System.Guid;
using STREAM_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("b502d1bc-9a57-11d0-8fde-00c04fd9189d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMultiMediaStream
    {
        [PreserveSig]
        HRESULT GetInformation(/* [out] */ out uint pdwFlags, /* [out] */ out __MIDL___MIDL_itf_mmstream_0000_0000_0001 pStreamType);
        
        [PreserveSig]
        HRESULT GetMediaStream(/* [in] */ ref REFMSPID idPurpose, /* [out] */ out IMediaStream ppMediaStream);
        
        [PreserveSig]
        HRESULT EnumMediaStreams(/* [in] */ int Index, /* [out] */ out IMediaStream ppMediaStream);
        
        [PreserveSig]
        HRESULT GetState(/* [out] */ out __MIDL___MIDL_itf_mmstream_0000_0000_0002 pCurrentState);
        
        [PreserveSig]
        HRESULT SetState(/* [in] */ __MIDL___MIDL_itf_mmstream_0000_0000_0002 NewState);
        
        [PreserveSig]
        HRESULT GetTime(/* [out] */ out STREAM_TIME pCurrentTime);
        
        [PreserveSig]
        HRESULT GetDuration(/* [out] */ out STREAM_TIME pDuration);
        
        [PreserveSig]
        HRESULT Seek(/* [in] */ long SeekTime);
        
        [PreserveSig]
        HRESULT GetEndOfStreamEventHandle(/* [out] */ out IntPtr phEOS);
    }
}
