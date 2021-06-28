// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_3.h(728,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Produces 2D pixel data that has been sourced from WIC.
    /// </summary>
    [ComImport, Guid("77395441-1c8f-4555-8683-f50dab0fe792"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1ImageSourceFromWic : ID2D1ImageSource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Image
        
        // ID2D1ImageSource
        [PreserveSig]
        new HRESULT OfferResources();
        
        [PreserveSig]
        new HRESULT TryReclaimResources(/* _Out_ */ out bool resourcesDiscarded);
        
        // ID2D1ImageSourceFromWic
        [PreserveSig]
        HRESULT EnsureCached(/* optional(D2D_RECT_U) */ IntPtr rectangleToFill);
        
        [PreserveSig]
        HRESULT TrimCache(/* optional(D2D_RECT_U) */ IntPtr rectangleToPreserve);
        
        [PreserveSig]
        void GetSource(/* _Outptr_result_maybenull_ */ out IWICBitmapSource wicBitmapSource);
    }
}
