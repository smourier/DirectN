// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("74c2653b-5f55-4eb1-9f0f-18b8f68b7d3d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFExtendedCameraIntrinsicsDistortionModel6KT
    {
        [PreserveSig]
        HRESULT GetDistortionModel(/* [annotation][out] _Out_ */ out _MFCameraIntrinsic_DistortionModel6KT pDistortionModel);
        
        [PreserveSig]
        HRESULT SetDistortionModel(/* [annotation][in] _In_ */ ref _MFCameraIntrinsic_DistortionModel6KT pDistortionModel);
    }
}
