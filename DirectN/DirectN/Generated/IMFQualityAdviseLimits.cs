// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dfcd8e4d-30b5-4567-acaa-8eb5b7853dc9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFQualityAdviseLimits
    {
        [PreserveSig]
        HRESULT GetMaximumDropMode(/* [annotation][out] _Out_ */ out _MF_QUALITY_DROP_MODE peDropMode);
        
        [PreserveSig]
        HRESULT GetMinimumQualityLevel(/* [annotation][out] _Out_ */ out _MF_QUALITY_LEVEL peQualityLevel);
    }
}
