// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(20585,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("812d5f95-b572-45dc-bafc-ae24199ddda8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFExtendedCameraIntrinsicsDistortionModelArcTan
    {
        [PreserveSig]
        HRESULT GetDistortionModel(/* [annotation][out] _Out_ */ out _MFCameraIntrinsic_DistortionModelArcTan pDistortionModel);
        
        [PreserveSig]
        HRESULT SetDistortionModel(/* [annotation][in] _In_ */ ref _MFCameraIntrinsic_DistortionModelArcTan pDistortionModel);
    }
}
