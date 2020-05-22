// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmcontainer.h(1770,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("12558295-e399-11d5-bc2a-00b0d0f3f4ab"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFASFSplitter
    {
        [PreserveSig]
        HRESULT Initialize(/* [in] */ IMFASFContentInfo pIContentInfo);
        
        [PreserveSig]
        HRESULT SetFlags(/* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT GetFlags(/* [out] */ out uint pdwFlags);
        
        [PreserveSig]
        HRESULT SelectStreams(/* [in] */ ref ushort pwStreamNumbers, /* [in] */ ushort wNumStreams);
        
        [PreserveSig]
        HRESULT GetSelectedStreams(/* [out] */ out ushort pwStreamNumbers, /* [out][in] */ ref ushort pwNumStreams);
        
        [PreserveSig]
        HRESULT ParseData(/* [in] */ IMFMediaBuffer pIBuffer, /* [in] */ uint cbBufferOffset, /* [in] */ uint cbLength);
        
        [PreserveSig]
        HRESULT GetNextSample(/* [out] */ out uint pdwStatusFlags, /* [out] */ out ushort pwStreamNumber, /* [out] */ out IMFSample ppISample);
        
        [PreserveSig]
        HRESULT Flush();
        
        [PreserveSig]
        HRESULT GetLastSendTime(/* [out] */ out uint pdwLastSendTime);
    }
}
