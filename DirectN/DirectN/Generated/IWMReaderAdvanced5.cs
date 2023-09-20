// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("24c44db0-55d1-49ae-a5cc-f13815e36363"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderAdvanced5 : IWMReaderAdvanced4
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
        new HRESULT SetPlayMode(/* [in] */ WMT_PLAY_MODE Mode);
        
        [PreserveSig]
        new HRESULT GetPlayMode(/* [out] */ out WMT_PLAY_MODE pMode);
        
        [PreserveSig]
        new HRESULT GetBufferProgress(/* [out] */ out uint pdwPercent, /* [out] */ out ulong pcnsBuffering);
        
        [PreserveSig]
        new HRESULT GetDownloadProgress(/* [out] */ out uint pdwPercent, /* [out] */ out ulong pqwBytesDownloaded, /* [out] */ out ulong pcnsDownload);
        
        [PreserveSig]
        new HRESULT GetSaveAsProgress(/* [out] */ out uint pdwPercent);
        
        [PreserveSig]
        new HRESULT SaveFileAs(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFilename);
        
        [PreserveSig]
        new HRESULT GetProtocolName(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [out][in] */ ref uint pcchProtocol);
        
        [PreserveSig]
        new HRESULT StartAtMarker(/* [in] */ ushort wMarkerIndex, /* [in] */ ulong cnsDuration, /* [in] */ float fRate, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        new HRESULT GetOutputSetting(/* [in] */ uint dwOutputNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
        
        [PreserveSig]
        new HRESULT SetOutputSetting(/* [in] */ uint dwOutputNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] */ WMT_ATTR_DATATYPE Type, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ ushort cbLength);
        
        [PreserveSig]
        new HRESULT Preroll(/* [in] */ ulong cnsStart, /* [in] */ ulong cnsDuration, /* [in] */ float fRate);
        
        [PreserveSig]
        new HRESULT SetLogClientID(/* [in] */ bool fLogClientID);
        
        [PreserveSig]
        new HRESULT GetLogClientID(/* [out] */ out bool pfLogClientID);
        
        [PreserveSig]
        new HRESULT StopBuffering();
        
        [PreserveSig]
        new HRESULT OpenStream(/* [in] */ IStream pStream, /* [in] */ IWMReaderCallback pCallback, /* [in] */ IntPtr pvContext);
        
        // IWMReaderAdvanced3
        [PreserveSig]
        new HRESULT StopNetStreaming();
        
        [PreserveSig]
        new HRESULT StartAtPosition(/* [in] */ ushort wStreamNum, /* [in] */ IntPtr pvOffsetStart, /* [in] */ IntPtr pvDuration, /* [in] */ tagWMT_OFFSET_FORMAT dwOffsetFormat, /* [in] */ float fRate, /* [in] */ IntPtr pvContext);
        
        // IWMReaderAdvanced4
        [PreserveSig]
        new HRESULT GetLanguageCount(/* [in] */ uint dwOutputNum, /* [out] */ out ushort pwLanguageCount);
        
        [PreserveSig]
        new HRESULT GetLanguage(/* [in] */ uint dwOutputNum, /* [in] */ ushort wLanguage, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguageString, /* [out][in] */ ref ushort pcchLanguageStringLength);
        
        [PreserveSig]
        new HRESULT GetMaxSpeedFactor(/* [out] */ out double pdblFactor);
        
        [PreserveSig]
        new HRESULT IsUsingFastCache(/* [out] */ out bool pfUsingFastCache);
        
        [PreserveSig]
        new HRESULT AddLogParam(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string wszNameSpace, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string wszName, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string wszValue);
        
        [PreserveSig]
        new HRESULT SendLogParams();
        
        [PreserveSig]
        new HRESULT CanSaveFileAs(/* [out] */ out bool pfCanSave);
        
        [PreserveSig]
        new HRESULT CancelSaveFileAs();
        
        [PreserveSig]
        new HRESULT GetURL(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [out][in] */ ref uint pcchURL);
        
        // IWMReaderAdvanced5
        [PreserveSig]
        HRESULT SetPlayerHook(/* [in] */ uint dwOutputNum, /* [in] */ IWMPlayerHook pHook);
    }
}
