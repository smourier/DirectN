// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcomp.h(1712,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("30c421d5-8cb2-4e9f-b133-37be270d4ac2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionFilterEffect : IDCompositionEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
    }
}
