// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406bea-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderAdvanced
    {
        [PreserveSig]
        HRESULT SetUserProvidedClock(/* [in] */ bool fUserClock);
        
        [PreserveSig]
        HRESULT GetUserProvidedClock(/* [out] */ out bool pfUserClock);
        
        [PreserveSig]
        HRESULT DeliverTime(/* [in] */ ulong cnsTime);
        
        [PreserveSig]
        HRESULT SetManualStreamSelection(/* [in] */ bool fSelection);
        
        [PreserveSig]
        HRESULT GetManualStreamSelection(/* [out] */ out bool pfSelection);
        
        [PreserveSig]
        HRESULT SetStreamsSelected(/* [in] */ ushort cStreamCount, /* [in] */ ref ushort pwStreamNumbers, /* [in] */ ref WMT_STREAM_SELECTION pSelections);
        
        [PreserveSig]
        HRESULT GetStreamSelected(/* [in] */ ushort wStreamNum, /* [out] */ out WMT_STREAM_SELECTION pSelection);
        
        [PreserveSig]
        HRESULT SetReceiveSelectionCallbacks(/* [in] */ bool fGetCallbacks);
        
        [PreserveSig]
        HRESULT GetReceiveSelectionCallbacks(/* [out] */ out bool pfGetCallbacks);
        
        [PreserveSig]
        HRESULT SetReceiveStreamSamples(/* [in] */ ushort wStreamNum, /* [in] */ bool fReceiveStreamSamples);
        
        [PreserveSig]
        HRESULT GetReceiveStreamSamples(/* [in] */ ushort wStreamNum, /* [out] */ out bool pfReceiveStreamSamples);
        
        [PreserveSig]
        HRESULT SetAllocateForOutput(/* [in] */ uint dwOutputNum, /* [in] */ bool fAllocate);
        
        [PreserveSig]
        HRESULT GetAllocateForOutput(/* [in] */ uint dwOutputNum, /* [out] */ out bool pfAllocate);
        
        [PreserveSig]
        HRESULT SetAllocateForStream(/* [in] */ ushort wStreamNum, /* [in] */ bool fAllocate);
        
        [PreserveSig]
        HRESULT GetAllocateForStream(/* [in] */ ushort dwSreamNum, /* [out] */ out bool pfAllocate);
        
        [PreserveSig]
        HRESULT GetStatistics(/* [out][in] */ ref _WMReaderStatistics pStatistics);
        
        [PreserveSig]
        HRESULT SetClientInfo(/* [in] */ ref _WMReaderClientInfo pClientInfo);
        
        [PreserveSig]
        HRESULT GetMaxOutputSampleSize(/* [in] */ uint dwOutput, /* [out] */ out uint pcbMax);
        
        [PreserveSig]
        HRESULT GetMaxStreamSampleSize(/* [in] */ ushort wStream, /* [out] */ out uint pcbMax);
        
        [PreserveSig]
        HRESULT NotifyLateDelivery(ulong cnsLateness);
    }
}
