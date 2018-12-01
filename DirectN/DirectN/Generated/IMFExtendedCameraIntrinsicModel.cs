// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(20385,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("5c595e64-4630-4231-855a-12842f733245"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
