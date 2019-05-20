// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(9880,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f3706f0d-8ea2-4886-8000-7155e9ec2eae"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFQualityAdvise2 : IMFQualityAdvise
    {
        // IMFQualityAdvise
        [PreserveSig]
        new HRESULT SetDropMode(/* [in] */ _MF_QUALITY_DROP_MODE eDropMode);
        
        [PreserveSig]
        new HRESULT SetQualityLevel(/* [in] */ _MF_QUALITY_LEVEL eQualityLevel);
        
        [PreserveSig]
        new HRESULT GetDropMode(/* [annotation][out] _Out_ */ out _MF_QUALITY_DROP_MODE peDropMode);
        
        [PreserveSig]
        new HRESULT GetQualityLevel(/* [annotation][out] _Out_ */ out _MF_QUALITY_LEVEL peQualityLevel);
        
        [PreserveSig]
        new HRESULT DropTime(/* [in] */ long hnsAmountToDrop);
        
        // IMFQualityAdvise2
        [PreserveSig]
        HRESULT NotifyQualityEvent(/* [in] __RPC__in_opt */ IMFMediaEvent pEvent, /* [out] __RPC__out */ out uint pdwFlags);
    }
}
