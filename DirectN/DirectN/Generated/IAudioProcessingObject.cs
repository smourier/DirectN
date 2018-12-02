// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audioenginebaseapo.h(561,5)
using System;
using System.Runtime.InteropServices;
using HNSTIME = System.Int64;

namespace DirectN
{
    [Guid("fd7f2b29-24d0-4b5c-b177-592c39f9ca10"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioProcessingObject
    {
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT GetLatency(/* [out] __RPC__out */ out HNSTIME pTime);
        
        [PreserveSig]
        HRESULT GetRegistrationProperties(/* optional(APO_REG_PROPERTIES) */ out IntPtr ppRegProps);
        
        [PreserveSig]
        HRESULT Initialize(/* [in] */ uint cbDataSize, /* [size_is][in] __RPC__in_ecount_full(cbDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pbyData);
        
        [PreserveSig]
        HRESULT IsInputFormatSupported(/* optional(IAudioMediaType) */ IntPtr pOppositeFormat, /* optional(IAudioMediaType) */ IntPtr pRequestedInputFormat, /* optional(IAudioMediaType) */ out IntPtr ppSupportedInputFormat);
        
        [PreserveSig]
        HRESULT IsOutputFormatSupported(/* optional(IAudioMediaType) */ IntPtr pOppositeFormat, /* optional(IAudioMediaType) */ IntPtr pRequestedOutputFormat, /* optional(IAudioMediaType) */ out IntPtr ppSupportedOutputFormat);
        
        [PreserveSig]
        HRESULT GetInputChannelCount(/* [out] __RPC__out */ out uint pu32ChannelCount);
    }
}
