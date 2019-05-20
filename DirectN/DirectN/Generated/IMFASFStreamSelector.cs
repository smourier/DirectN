// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmcontainer.h(2243,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d01bad4a-4fa0-4a60-9349-c27e62da9d41"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFASFStreamSelector
    {
        [PreserveSig]
        HRESULT GetStreamCount(/* [out] */ out uint pcStreams);
        
        [PreserveSig]
        HRESULT GetOutputCount(/* [out] */ out uint pcOutputs);
        
        [PreserveSig]
        HRESULT GetOutputStreamCount(/* [in] */ uint dwOutputNum, /* [out] */ out uint pcStreams);
        
        [PreserveSig]
        HRESULT GetOutputStreamNumbers(/* [in] */ uint dwOutputNum, /* [out] */ out ushort rgwStreamNumbers);
        
        [PreserveSig]
        HRESULT GetOutputFromStream(/* [in] */ ushort wStreamNum, /* [out] */ out uint pdwOutput);
        
        [PreserveSig]
        HRESULT GetOutputOverride(/* [in] */ uint dwOutputNum, /* [out] */ out ASF_SELECTION_STATUS pSelection);
        
        [PreserveSig]
        HRESULT SetOutputOverride(/* [in] */ uint dwOutputNum, /* [in] */ ASF_SELECTION_STATUS Selection);
        
        [PreserveSig]
        HRESULT GetOutputMutexCount(/* [in] */ uint dwOutputNum, /* [out] */ out uint pcMutexes);
        
        [PreserveSig]
        HRESULT GetOutputMutex(/* [in] */ uint dwOutputNum, /* [in] */ uint dwMutexNum, /* [out] */ [MarshalAs(UnmanagedType.IUnknown)] out object ppMutex);
        
        [PreserveSig]
        HRESULT SetOutputMutexSelection(/* [in] */ uint dwOutputNum, /* [in] */ uint dwMutexNum, /* [in] */ ushort wSelectedRecord);
        
        [PreserveSig]
        HRESULT GetBandwidthStepCount(/* [out] */ out uint pcStepCount);
        
        [PreserveSig]
        HRESULT GetBandwidthStep(/* [in] */ uint dwStepNum, /* [out] */ out uint pdwBitrate, /* [out] */ out ushort rgwStreamNumbers, /* [out] */ out ASF_SELECTION_STATUS rgSelections);
        
        [PreserveSig]
        HRESULT BitrateToStepNumber(/* [in] */ uint dwBitrate, /* [out] */ out uint pdwStepNum);
        
        [PreserveSig]
        HRESULT SetStreamSelectorFlags(/* [in] */ uint dwStreamSelectorFlags);
    }
}
