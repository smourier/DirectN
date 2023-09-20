// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ec15e2e9-e36b-4f7c-8758-77d452ef4ce7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFQualityAdvise
    {
        [PreserveSig]
        HRESULT SetDropMode(/* [in] */ _MF_QUALITY_DROP_MODE eDropMode);
        
        [PreserveSig]
        HRESULT SetQualityLevel(/* [in] */ _MF_QUALITY_LEVEL eQualityLevel);
        
        [PreserveSig]
        HRESULT GetDropMode(/* [annotation][out] _Out_ */ out _MF_QUALITY_DROP_MODE peDropMode);
        
        [PreserveSig]
        HRESULT GetQualityLevel(/* [annotation][out] _Out_ */ out _MF_QUALITY_LEVEL peQualityLevel);
        
        [PreserveSig]
        HRESULT DropTime(/* [in] */ long hnsAmountToDrop);
    }
}
