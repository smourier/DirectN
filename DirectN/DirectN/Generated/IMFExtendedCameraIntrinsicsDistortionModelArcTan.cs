// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("812d5f95-b572-45dc-bafc-ae24199ddda8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFExtendedCameraIntrinsicsDistortionModelArcTan
    {
        [PreserveSig]
        HRESULT GetDistortionModel(/* [annotation][out] _Out_ */ out _MFCameraIntrinsic_DistortionModelArcTan pDistortionModel);
        
        [PreserveSig]
        HRESULT SetDistortionModel(/* [annotation][in] _In_ */ ref _MFCameraIntrinsic_DistortionModelArcTan pDistortionModel);
    }
}
