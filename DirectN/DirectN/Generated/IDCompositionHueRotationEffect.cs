// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcomp.h(1850,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6db9f920-0770-4781-b0c6-381912f9d167"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionHueRotationEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionHueRotationEffect
        [PreserveSig]
        HRESULT SetAngle(/* THIS_ _In_ */ float amountDegrees);
        
        [PreserveSig]
        HRESULT SetAngle(/* THIS_ _In_ */ IDCompositionAnimation animation);
    }
}
