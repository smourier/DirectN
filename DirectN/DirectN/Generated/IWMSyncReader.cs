// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(3609,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("9397f121-7705-4dc9-b049-98b698188414"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMSyncReader
    {
        [PreserveSig]
        HRESULT Open(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszFilename);
        
        [PreserveSig]
        HRESULT Close();
        
        [PreserveSig]
        HRESULT SetRange(/* [in] */ ulong cnsStartTime, /* [in] */ long cnsDuration);
        
        [PreserveSig]
        HRESULT SetRangeByFrame(/* [in] */ ushort wStreamNum, /* [in] */ ulong qwFrameNumber, /* [in] */ long cFramesToRead);
        
        [PreserveSig]
        HRESULT GetNextSample(/* [in] */ ushort wStreamNum, /* [out] */ out INSSBuffer ppSample, /* [out] */ out ulong pcnsSampleTime, /* [out] */ out ulong pcnsDuration, /* [out] */ out uint pdwFlags, /* [out] */ out uint pdwOutputNum, /* [out] */ out ushort pwStreamNum);
        
        [PreserveSig]
        HRESULT SetStreamsSelected(/* [in] */ ushort cStreamCount, /* [in] */ ref ushort pwStreamNumbers, /* [in] */ ref WMT_STREAM_SELECTION pSelections);
        
        [PreserveSig]
        HRESULT GetStreamSelected(/* [in] */ ushort wStreamNum, /* [out] */ out WMT_STREAM_SELECTION pSelection);
        
        [PreserveSig]
        HRESULT SetReadStreamSamples(/* [in] */ ushort wStreamNum, /* [in] */ bool fCompressed);
        
        [PreserveSig]
        HRESULT GetReadStreamSamples(/* [in] */ ushort wStreamNum, /* [out] */ out bool pfCompressed);
        
        [PreserveSig]
        HRESULT GetOutputSetting(/* [in] */ uint dwOutputNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
        
        [PreserveSig]
        HRESULT SetOutputSetting(/* [in] */ uint dwOutputNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] */ WMT_ATTR_DATATYPE Type, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ ushort cbLength);
        
        [PreserveSig]
        HRESULT GetOutputCount(/* [out] */ out uint pcOutputs);
        
        [PreserveSig]
        HRESULT GetOutputProps(/* [in] */ uint dwOutputNum, /* [out] */ out IWMOutputMediaProps ppOutput);
        
        [PreserveSig]
        HRESULT SetOutputProps(/* [in] */ uint dwOutputNum, /* [in] */ IWMOutputMediaProps pOutput);
        
        [PreserveSig]
        HRESULT GetOutputFormatCount(/* [in] */ uint dwOutputNum, /* [out] */ out uint pcFormats);
        
        [PreserveSig]
        HRESULT GetOutputFormat(/* [in] */ uint dwOutputNum, /* [in] */ uint dwFormatNum, /* [out] */ out IWMOutputMediaProps ppProps);
        
        [PreserveSig]
        HRESULT GetOutputNumberForStream(/* [in] */ ushort wStreamNum, /* [out] */ out uint pdwOutputNum);
        
        [PreserveSig]
        HRESULT GetStreamNumberForOutput(/* [in] */ uint dwOutputNum, /* [out] */ out ushort pwStreamNum);
        
        [PreserveSig]
        HRESULT GetMaxOutputSampleSize(/* [in] */ uint dwOutput, /* [out] */ out uint pcbMax);
        
        [PreserveSig]
        HRESULT GetMaxStreamSampleSize(/* [in] */ ushort wStream, /* [out] */ out uint pcbMax);
        
        [PreserveSig]
        HRESULT OpenStream(/* [in] */ IStream pStream);
    }
}
