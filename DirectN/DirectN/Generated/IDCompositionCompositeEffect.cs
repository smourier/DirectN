// generated from <Windows SDK Path>\um\dcomp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("576616c0-a231-494d-a38d-00fd5ec4db46"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionCompositeEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionCompositeEffect
        [PreserveSig]
        HRESULT SetMode(/* THIS_ _In_ */ D2D1_COMPOSITE_MODE mode);
    }
}
