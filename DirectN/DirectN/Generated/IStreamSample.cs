// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mmstream.h(470,5)
using System;
using System.Runtime.InteropServices;
using PAPCFUNC = System.IntPtr;
using STREAM_TIME = System.Int64;

namespace DirectN
{
    [Guid("b502d1be-9a57-11d0-8fde-00c04fd9189d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IStreamSample
    {
        [PreserveSig]
        HRESULT GetMediaStream(/* [in] */ IMediaStream ppMediaStream);
        
        [PreserveSig]
        HRESULT GetSampleTimes(/* [out] */ out STREAM_TIME pStartTime, /* [out] */ out STREAM_TIME pEndTime, /* [out] */ out STREAM_TIME pCurrentTime);
        
        [PreserveSig]
        HRESULT SetSampleTimes(/* [in] */ ref STREAM_TIME pStartTime, /* [in] */ ref STREAM_TIME pEndTime);
        
        [PreserveSig]
        HRESULT Update(/* [in] */ uint dwFlags, /* [in] */ IntPtr hEvent, /* [in] */ ref PAPCFUNC pfnAPC, /* [in] */ IntPtr dwAPCData);
        
        [PreserveSig]
        HRESULT CompletionStatus(/* [in] */ uint dwFlags, /* [in] */ uint dwMilliseconds);
    }
}
