// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcomp.h(949,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d8f5b23f-d429-4a91-b55a-d2f45fd75b18"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionRotateTransform3D : IDCompositionTransform3D
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionRotateTransform3D
        [PreserveSig]
        HRESULT SetAngle(float angle);
        
        [PreserveSig]
        HRESULT SetAngle(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetAxisX(float axisX);
        
        [PreserveSig]
        HRESULT SetAxisX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetAxisY(float axisY);
        
        [PreserveSig]
        HRESULT SetAxisY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetAxisZ(float axisZ);
        
        [PreserveSig]
        HRESULT SetAxisZ(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterX(float centerX);
        
        [PreserveSig]
        HRESULT SetCenterX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterY(float centerY);
        
        [PreserveSig]
        HRESULT SetCenterY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterZ(float centerZ);
        
        [PreserveSig]
        HRESULT SetCenterZ(/* THIS_ _In_ */ IDCompositionAnimation animation);
    }
}
