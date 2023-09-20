// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5c595e64-4630-4231-855a-12842f733245"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFExtendedCameraIntrinsicModel
    {
        [PreserveSig]
        HRESULT GetModel(/* [annotation][out] _Out_ */ out _MFExtendedCameraIntrinsic_IntrinsicModel pIntrinsicModel);
        
        [PreserveSig]
        HRESULT SetModel(/* [annotation][in] _In_ */ ref _MFExtendedCameraIntrinsic_IntrinsicModel pIntrinsicModel);
        
        [PreserveSig]
        HRESULT GetDistortionModelType(/* [annotation][out] _Out_ */ out _MFCameraIntrinsic_DistortionModelType pDistortionModelType);
    }
}
