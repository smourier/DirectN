// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(10869,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("ae14a945-b90c-4d0d-9127-80d665f7d73e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderAdvanced2 : IWMReaderAdvanced
    {
        // IWMReaderAdvanced
        [PreserveSig]
        new HRESULT SetUserProvidedClock(/* [in] */ bool fUserClock);
        
        [PreserveSig]
        new HRESULT GetUserProvidedClock(/* [out] */ out bool pfUserClock);
        
        [PreserveSig]
        new HRESULT DeliverTime(/* [in] */ ulong cnsTime);
        
        [PreserveSig]
        new HRESULT SetManualStreamSelection(/* [in] */ bool fSelection);
        
        [PreserveSig]
        new HRESULT GetManualStreamSelection(/* [out] */ out bool pfSelection);
        
        [PreserveSig]
        new HRESULT SetStreamsSelected(/* [in] */ ushort cStreamCount, /* [in] */ ref ushort pwStreamNumbers, /* [in] */ ref WMT_STREAM_SELECTION pSelections);
        
        [PreserveSig]
        new HRESULT GetStreamSelected(/* [in] */ ushort wStreamNum, /* [out] */ out WMT_STREAM_SELECTION pSelection);
        
        [PreserveSig]
        new HRESULT SetReceiveSelectionCallbacks(/* [in] */ bool fGetCallbacks);
        
        [PreserveSig]
        new HRESULT GetReceiveSelectionCallbacks(/* [out] */ out bool pfGetCallbacks);
        
        [PreserveSig]
        new HRESULT SetReceiveStreamSamples(/* [in] */ ushort wStreamNum, /* [in] */ bool fReceiveStreamSamples);
        
        [PreserveSig]
        new HRESULT GetReceiveStreamSamples(/* [in] */ ushort wStreamNum, /* [out] */ out bool pfReceiveStreamSamples);
        
        [PreserveSig]
        new HRESULT SetAllocateForOutput(/* [in] */ uint dwOutputNum, /* [in] */ bool fAllocate);
        
        [PreserveSig]
        new HRESULT GetAllocateForOutput(/* [in] */ uint dwOutputNum, /* [out] */ out bool pfAllocate);
        
        [PreserveSig]
        new HRESULT SetAllocateForStream(/* [in] */ ushort wStreamNum, /* [in] */ bool fAllocate);
        
        [PreserveSig]
        new HRESULT GetAllocateForStream(/* [in] */ ushort dwSreamNum, /* [out] */ out bool pfAllocate);
        
        [PreserveSig]
        new HRESULT GetStatistics(/* [out][in] */ ref _WMReaderStatistics pStatistics);
        
        [PreserveSig]
        new HRESULT SetClientInfo(/* [in] */ ref _WMReaderClientInfo pClientInfo);
        
        [PreserveSig]
        new HRESULT GetMaxOutputSampleSize(/* [in] */ uint dwOutput, /* [out] */ out uint pcbMax);
        
        [PreserveSig]
        new HRESULT GetMaxStreamSampleSize(/* [in] */ ushort wStream, /* [out] */ out uint pcbMax);
        
        [PreserveSig]
        new HRESULT NotifyLateDelivery(ulong cnsLateness);
        
        // IWMReaderAdvanced2
        [PreserveSig]
        HRESULT SetPlayMode(/* [in] */ WMT_PLAY_MODE Mode);
        
        [PreserveSig]
        HRESULT GetPlayMode(/* [out] */ out WMT_PLAY_MODE pMode);
        
        [PreserveSig]
        HRESULT GetBufferProgress(/* [out] */ out uint pdwPercent, /* [out] */ out ulong pcnsBuffering);
        
        [PreserveSig]
        HRESULT GetDownloadProgress(/* [out] */ out uint pdwPercent, /* [out] */ out ulong pqwBytesDownloaded, /* [out] */ out ulong pcnsDownload);
        
        [PreserveSig]
        HRESULT GetSaveAsProgress(/* [out] */ out uint pdwPercent);
        
        [PreserveSig]
        HRESULT SaveFileAs(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFilename);
        
        [PreserveSig]
        HRESULT GetProtocolName(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [out][in] */ ref uint pcchProtocol);
        
        [PreserveSig]
        HRESULT StartAtMarker(/* [in] */ ushort wMarkerIndex, /* [in] */ ulong cnsDuration, /* [in] */ float fRate, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT GetOutputSetting(/* [in] */ uint dwOutputNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
        
        [PreserveSig]
        HRESULT SetOutputSetting(/* [in] */ uint dwOutputNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] */ WMT_ATTR_DATATYPE Type, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ ushort cbLength);
        
        [PreserveSig]
        HRESULT Preroll(/* [in] */ ulong cnsStart, /* [in] */ ulong cnsDuration, /* [in] */ float fRate);
        
        [PreserveSig]
        HRESULT SetLogClientID(/* [in] */ bool fLogClientID);
        
        [PreserveSig]
        HRESULT GetLogClientID(/* [out] */ out bool pfLogClientID);
        
        [PreserveSig]
        HRESULT StopBuffering();
        
        [PreserveSig]
        HRESULT OpenStream(/* [in] */ IStream pStream, /* [in] */ IWMReaderCallback pCallback, /* [in] */ IntPtr pvContext);
    }
}
