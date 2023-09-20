// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a7929a74-e6b2-4bd6-8b95-4040119ca34d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionEffectGroup : IDCompositionEffect
    {
        // IDCompositionEffect
        
        // IDCompositionEffectGroup
        [PreserveSig]
        HRESULT SetOpacity(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetOpacity(float opacity);
        
        [PreserveSig]
        HRESULT SetTransform3D(/* THIS_ _In_opt_ */ IDCompositionTransform3D transform3D);
    }
}
