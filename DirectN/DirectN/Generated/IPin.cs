// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(1241,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56a86891-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPin
    {
        [PreserveSig]
        HRESULT Connect(/* [in] */ IPin pReceivePin, /* optional(_AMMediaType) */ IntPtr pmt);
        
        [PreserveSig]
        HRESULT ReceiveConnection(/* [in] */ IPin pConnector, /* [in] */ ref _AMMediaType pmt);
        
        [PreserveSig]
        HRESULT Disconnect();
        
        [PreserveSig]
        HRESULT ConnectedTo(/* [annotation][out] _Out_ */ out IPin pPin);
        
        [PreserveSig]
        HRESULT ConnectionMediaType(/* [annotation][out] _Out_ */ out _AMMediaType pmt);
        
        [PreserveSig]
        HRESULT QueryPinInfo(/* [annotation][out] _Out_ */ out _PinInfo pInfo);
        
        [PreserveSig]
        HRESULT QueryDirection(/* [annotation][out] _Out_ */ out _PinDirection pPinDir);
        
        [PreserveSig]
        HRESULT QueryId(/* [annotation][out] _Out_ */ out IntPtr Id);
        
        [PreserveSig]
        HRESULT QueryAccept(/* [in] */ ref _AMMediaType pmt);
        
        [PreserveSig]
        HRESULT EnumMediaTypes(/* [annotation][out] _Out_ */ out IEnumMediaTypes ppEnum);
        
        [PreserveSig]
        HRESULT QueryInternalConnections(/* optional(IPin) */ out IntPtr apPin, /* [out][in] */ ref uint nPin);
        
        [PreserveSig]
        HRESULT EndOfStream();
        
        [PreserveSig]
        HRESULT BeginFlush();
        
        [PreserveSig]
        HRESULT EndFlush();
        
        [PreserveSig]
        HRESULT NewSegment(/* [in] */ long tStart, /* [in] */ long tStop, /* [in] */ double dRate);
    }
}
