// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(3949,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("faed3d21-1b6b-4af7-8cb6-3e189bbc187b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMSyncReader2 : IWMSyncReader
    {
        // IWMSyncReader
        [PreserveSig]
        new HRESULT Open(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFilename);
        
        [PreserveSig]
        new HRESULT Close();
        
        [PreserveSig]
        new HRESULT SetRange(/* [in] */ ulong cnsStartTime, /* [in] */ long cnsDuration);
        
        [PreserveSig]
        new HRESULT SetRangeByFrame(/* [in] */ ushort wStreamNum, /* [in] */ ulong qwFrameNumber, /* [in] */ long cFramesToRead);
        
        [PreserveSig]
        new HRESULT GetNextSample(/* [in] */ ushort wStreamNum, /* [out] */ out INSSBuffer ppSample, /* [out] */ out ulong pcnsSampleTime, /* [out] */ out ulong pcnsDuration, /* [out] */ out uint pdwFlags, /* [out] */ out uint pdwOutputNum, /* [out] */ out ushort pwStreamNum);
        
        [PreserveSig]
        new HRESULT SetStreamsSelected(/* [in] */ ushort cStreamCount, /* [in] */ ref ushort pwStreamNumbers, /* [in] */ ref WMT_STREAM_SELECTION pSelections);
        
        [PreserveSig]
        new HRESULT GetStreamSelected(/* [in] */ ushort wStreamNum, /* [out] */ out WMT_STREAM_SELECTION pSelection);
        
        [PreserveSig]
        new HRESULT SetReadStreamSamples(/* [in] */ ushort wStreamNum, /* [in] */ bool fCompressed);
        
        [PreserveSig]
        new HRESULT GetReadStreamSamples(/* [in] */ ushort wStreamNum, /* [out] */ out bool pfCompressed);
        
        [PreserveSig]
        new HRESULT GetOutputSetting(/* [in] */ uint dwOutputNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
        
        [PreserveSig]
        new HRESULT SetOutputSetting(/* [in] */ uint dwOutputNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] */ WMT_ATTR_DATATYPE Type, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ ushort cbLength);
        
        [PreserveSig]
        new HRESULT GetOutputCount(/* [out] */ out uint pcOutputs);
        
        [PreserveSig]
        new HRESULT GetOutputProps(/* [in] */ uint dwOutputNum, /* [out] */ out IWMOutputMediaProps ppOutput);
        
        [PreserveSig]
        new HRESULT SetOutputProps(/* [in] */ uint dwOutputNum, /* [in] */ IWMOutputMediaProps pOutput);
        
        [PreserveSig]
        new HRESULT GetOutputFormatCount(/* [in] */ uint dwOutputNum, /* [out] */ out uint pcFormats);
        
        [PreserveSig]
        new HRESULT GetOutputFormat(/* [in] */ uint dwOutputNum, /* [in] */ uint dwFormatNum, /* [out] */ out IWMOutputMediaProps ppProps);
        
        [PreserveSig]
        new HRESULT GetOutputNumberForStream(/* [in] */ ushort wStreamNum, /* [out] */ out uint pdwOutputNum);
        
        [PreserveSig]
        new HRESULT GetStreamNumberForOutput(/* [in] */ uint dwOutputNum, /* [out] */ out ushort pwStreamNum);
        
        [PreserveSig]
        new HRESULT GetMaxOutputSampleSize(/* [in] */ uint dwOutput, /* [out] */ out uint pcbMax);
        
        [PreserveSig]
        new HRESULT GetMaxStreamSampleSize(/* [in] */ ushort wStream, /* [out] */ out uint pcbMax);
        
        [PreserveSig]
        new HRESULT OpenStream(/* [in] */ IStream pStream);
        
        // IWMSyncReader2
        [PreserveSig]
        HRESULT SetRangeByTimecode(/* [in] */ ushort wStreamNum, /* [in] */ ref _WMT_TIMECODE_EXTENSION_DATA pStart, /* [in] */ ref _WMT_TIMECODE_EXTENSION_DATA pEnd);
        
        [PreserveSig]
        HRESULT SetRangeByFrameEx(/* [in] */ ushort wStreamNum, /* [in] */ ulong qwFrameNumber, /* [in] */ long cFramesToRead, /* [out] */ out ulong pcnsStartTime);
        
        [PreserveSig]
        HRESULT SetAllocateForOutput(/* [in] */ uint dwOutputNum, /* [in] */ IWMReaderAllocatorEx pAllocator);
        
        [PreserveSig]
        HRESULT GetAllocateForOutput(/* [in] */ uint dwOutputNum, /* [out] */ out IWMReaderAllocatorEx ppAllocator);
        
        [PreserveSig]
        HRESULT SetAllocateForStream(/* [in] */ ushort wStreamNum, /* [in] */ IWMReaderAllocatorEx pAllocator);
        
        [PreserveSig]
        HRESULT GetAllocateForStream(/* [in] */ ushort dwSreamNum, /* [out] */ out IWMReaderAllocatorEx ppAllocator);
    }
}
